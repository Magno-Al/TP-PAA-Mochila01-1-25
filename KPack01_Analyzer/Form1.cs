using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using MathNet.Numerics;

namespace KPack01_Analyzer
{
    public partial class mainForm : Form
    {
        public class ExecutionResult
        {
            public long ExecutionTime { get; set; }
            public double PeakMemoryMB { get; set; }
            public int SolutionValue { get; set; }
            public string ConsoleOutput { get; set; }
        }

        private Random randomGenerator = new Random();

        public mainForm()
        {
            InitializeComponent();
        }

        private void selectExeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione o executável do algoritmo";
            openFileDialog.Filter = "Executáveis (*.exe)|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                exePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string exePath = exePathTextBox.Text;
            if (!File.Exists(exePath))
            {
                MessageBox.Show("Executable not found at the specified path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            executeButton.Enabled = false;

            resultsDataGridView.Rows.Clear();
            performanceChart.Series["ExecutionTime"].Points.Clear();
            performanceChart.Series["FittedCurve"].Points.Clear();
            richTextBox1.Clear();

            var xDataPoints = new List<double>();
            var yDataPoints = new List<double>();

            int minValue = (int)minValueNumeric.Value;
            int maxValue = (int)maxValueNumeric.Value;
            int minWeight = (int)minWeightNumeric.Value;
            int maxWeight = (int)maxWeightNumeric.Value;

            if (minValue > maxValue || minWeight > maxWeight)
            {
                MessageBox.Show("O valor mínimo não pode ser maior que o valor máximo para os ranges de valor/peso.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int executionCount = (int)executionCountNumeric.Value;
            int currentItems = (int)initialItemsNumeric.Value;
            int currentCapacity = (int)initialCapacityNumeric.Value;
            int itemsIncrement = (int)itemsIncrementNumeric.Value;
            int capacityIncrement = (int)capacityIncrementNumeric.Value;

            for (int i = 0; i < executionCount; i++)
            {
                string tempInstanceFile = null;
                try
                {
                    tempInstanceFile = GenerateArgumentString(currentCapacity, currentItems, minValue, maxValue, minWeight, maxWeight);

                    ExecutionResult result = RunProcessAndGetResult(exePath, tempInstanceFile);

                    resultsDataGridView.Rows.Add(
                        i + 1,
                        currentItems,
                        currentCapacity,
                        result.ExecutionTime,
                        $"{result.PeakMemoryMB:F2}",
                        "N/A",
                        result.SolutionValue
                    );

                    richTextBox1.AppendText($"--- Execucao Instancia {i + 1} ---\n");
                    richTextBox1.AppendText(string.IsNullOrEmpty(result.ConsoleOutput) ? "[No output]\n\n" : result.ConsoleOutput + "\n");

                    xDataPoints.Add(currentItems);
                    yDataPoints.Add(result.ExecutionTime);

                    performanceChart.Series["ExecutionTime"].Points.AddXY(currentItems, result.ExecutionTime);

                    Application.DoEvents();

                    currentItems += itemsIncrement;
                    currentCapacity += capacityIncrement;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during execution: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                finally
                {
                    if (tempInstanceFile != null && File.Exists(tempInstanceFile))
                    {
                        File.Delete(tempInstanceFile);
                    }
                }
            }

            if (xDataPoints.Count > 2)
            {
                AnalyzeAndPlotBestFit(xDataPoints, yDataPoints);
            }

            executeButton.Enabled = true;
            MessageBox.Show("Análise concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private ExecutionResult RunProcessAndGetResult(string exePath, string arguments)
        {
            var result = new ExecutionResult();
            var stopwatch = new Stopwatch();

            using (Process process = new Process())
            {
                process.StartInfo.FileName = exePath;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(exePath);

                stopwatch.Start();
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();
                stopwatch.Stop();

                result.ConsoleOutput = output + error;

                result.ExecutionTime = stopwatch.ElapsedMilliseconds;

                try
                {
                    result.PeakMemoryMB = process.PeakWorkingSet64 / 1024.0 / 1024.0;

                    var outputLines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in outputLines)
                    {
                        if (line.StartsWith("Valor Solucao:", StringComparison.OrdinalIgnoreCase))
                        {
                            result.SolutionValue = int.Parse(line.Split(':')[1].Trim());
                            break;
                        }
                    }
                }
                catch (InvalidOperationException) { }

                return result;
            }
        }
        private string GenerateArgumentString(int capacity, int itemCount, int minValue, int maxValue, int minWeight, int maxWeight)
        {
            var argumentBuilder = new StringBuilder();
            argumentBuilder.Append(capacity).Append(" ").Append(itemCount).Append(" ");
            var itemList = new List<string>();
            for (int i = 0; i < itemCount; i++)
            {
                int value = randomGenerator.Next(minValue, maxValue + 1);
                int weight = randomGenerator.Next(minWeight, maxWeight + 1);
                itemList.Add($"{value},{weight}");
            }
            argumentBuilder.Append(string.Join(";", itemList));
            return argumentBuilder.ToString();
        }

        private void AnalyzeAndPlotBestFit(List<double> xData, List<double> yData)
        {
            if (xData.Count < 3)
            {
                complexityLabel.Text = "Pontos insuficientes";
                asymptoticBehaviorLabel.Text = "Execute mais instâncias";
                return;
            }

            var xArray = xData.ToArray();
            var yArray = yData.ToArray();
            double meanY = yData.Average();
            double ssTotal = yData.Sum(y => Math.Pow(y - meanY, 2));

            var fitResults = new Dictionary<string, (Func<double, double> func, double r2Adjusted, int degree)>();

            // Ajuste Linear: O(n)
            var linear = Fit.Line(xArray, yArray);
            Func<double, double> fLinear = x => linear.Item1 + linear.Item2 * x;
            double r2Linear = CalculateAdjustedR2(fLinear, xData, yData, ssTotal, 1);
            fitResults["O(n)"] = (fLinear, r2Linear, 1);

            // Ajuste Quadrático: O(n²)
            if (xData.Count >= 4)
            {
                var quad = Fit.Polynomial(xArray, yArray, 2);
                Func<double, double> fQuad = x => quad[0] + quad[1] * x + quad[2] * x * x;
                double r2Quad = CalculateAdjustedR2(fQuad, xData, yData, ssTotal, 2);
                fitResults["O(n²)"] = (fQuad, r2Quad, 2);
            }

            // Ajuste Cúbico: O(n³)
            if (xData.Count >= 5)
            {
                var cubic = Fit.Polynomial(xArray, yArray, 3);
                Func<double, double> fCubic = x => cubic[0] + cubic[1] * x + cubic[2] * x * x + cubic[3] * x * x * x;
                double r2Cubic = CalculateAdjustedR2(fCubic, xData, yData, ssTotal, 3);
                fitResults["O(n³)"] = (fCubic, r2Cubic, 3);
            }

            var bestFit = fitResults.OrderByDescending(fr => fr.Value.r2Adjusted).First();
            string bestLabel = bestFit.Key;
            Func<double, double> bestFunc = bestFit.Value.func;

            complexityLabel.Text = $"Complexidade estimada: {bestLabel}";
            asymptoticBehaviorLabel.Text = $"R² ajustado: {bestFit.Value.r2Adjusted:F4}";

            var fittedCurveSeries = performanceChart.Series["FittedCurve"];
            fittedCurveSeries.Points.Clear();

            for (double x = xData.Min(); x <= xData.Max(); x += (xData.Max() - xData.Min()) / 100.0)
            {
                fittedCurveSeries.Points.AddXY(x, bestFunc(x));
            }
        }

        private double CalculateAdjustedR2(Func<double, double> func, List<double> x, List<double> y, double ssTotal, int degree)
        {
            double ssRes = 0;
            for (int i = 0; i < x.Count; i++)
            {
                ssRes += Math.Pow(y[i] - func(x[i]), 2);
            }

            int n = x.Count;
            int p = degree + 1;

            double r2 = 1 - ssRes / ssTotal;
            double adjustedR2 = 1 - (1 - r2) * (n - 1) / (n - p - 1);
            return adjustedR2;
        }

    }
}