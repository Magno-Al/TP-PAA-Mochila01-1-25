namespace KPack01_Analyzer
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            selectExeButton = new Button();
            exePathTextBox = new TextBox();
            initialItemsNumeric = new NumericUpDown();
            executionCountNumeric = new NumericUpDown();
            initialCapacityNumeric = new NumericUpDown();
            resultsDataGridView = new DataGridView();
            colInstance = new DataGridViewTextBoxColumn();
            colItems = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colMemory = new DataGridViewTextBoxColumn();
            colExpectedValue = new DataGridViewTextBoxColumn();
            colSolutionValue = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            capacityIncrementNumeric = new NumericUpDown();
            itemsIncrementNumeric = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            performanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label6 = new Label();
            label7 = new Label();
            executeButton = new Button();
            richTextBox1 = new RichTextBox();
            complexityLabel = new Label();
            asymptoticBehaviorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)initialItemsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)executionCountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCapacityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capacityIncrementNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsIncrementNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)performanceChart).BeginInit();
            SuspendLayout();
            // 
            // selectExeButton
            // 
            selectExeButton.Location = new Point(12, 12);
            selectExeButton.Name = "selectExeButton";
            selectExeButton.Size = new Size(136, 23);
            selectExeButton.TabIndex = 0;
            selectExeButton.Text = "Selecionar algoritmo";
            selectExeButton.UseVisualStyleBackColor = true;
            selectExeButton.Click += selectExeButton_Click;
            // 
            // exePathTextBox
            // 
            exePathTextBox.Location = new Point(154, 12);
            exePathTextBox.Name = "exePathTextBox";
            exePathTextBox.ReadOnly = true;
            exePathTextBox.Size = new Size(453, 23);
            exePathTextBox.TabIndex = 1;
            // 
            // initialItemsNumeric
            // 
            initialItemsNumeric.Location = new Point(140, 101);
            initialItemsNumeric.Name = "initialItemsNumeric";
            initialItemsNumeric.Size = new Size(51, 23);
            initialItemsNumeric.TabIndex = 3;
            // 
            // executionCountNumeric
            // 
            executionCountNumeric.Location = new Point(613, 14);
            executionCountNumeric.Name = "executionCountNumeric";
            executionCountNumeric.Size = new Size(51, 23);
            executionCountNumeric.TabIndex = 4;
            // 
            // initialCapacityNumeric
            // 
            initialCapacityNumeric.Location = new Point(140, 72);
            initialCapacityNumeric.Name = "initialCapacityNumeric";
            initialCapacityNumeric.Size = new Size(51, 23);
            initialCapacityNumeric.TabIndex = 5;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { colInstance, colItems, colCapacity, colTime, colMemory, colExpectedValue, colSolutionValue });
            resultsDataGridView.Location = new Point(771, 181);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.ReadOnly = true;
            resultsDataGridView.Size = new Size(557, 379);
            resultsDataGridView.TabIndex = 6;
            // 
            // colInstance
            // 
            colInstance.HeaderText = "Instância";
            colInstance.Name = "colInstance";
            colInstance.ReadOnly = true;
            // 
            // colItems
            // 
            colItems.HeaderText = "Itens";
            colItems.Name = "colItems";
            colItems.ReadOnly = true;
            // 
            // colCapacity
            // 
            colCapacity.HeaderText = "Capacidade";
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.HeaderText = "Tempo (ms)";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colMemory
            // 
            colMemory.HeaderText = "Maior memoria";
            colMemory.Name = "colMemory";
            colMemory.ReadOnly = true;
            // 
            // colExpectedValue
            // 
            colExpectedValue.HeaderText = "Valor esperado";
            colExpectedValue.Name = "colExpectedValue";
            colExpectedValue.ReadOnly = true;
            // 
            // colSolutionValue
            // 
            colSolutionValue.HeaderText = "Valor Solução";
            colSolutionValue.Name = "colSolutionValue";
            colSolutionValue.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 74);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 7;
            label1.Text = "Capacidade inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 103);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Itens inicial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 20);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 9;
            label3.Text = "X";
            // 
            // capacityIncrementNumeric
            // 
            capacityIncrementNumeric.Location = new Point(327, 72);
            capacityIncrementNumeric.Name = "capacityIncrementNumeric";
            capacityIncrementNumeric.Size = new Size(51, 23);
            capacityIncrementNumeric.TabIndex = 11;
            // 
            // itemsIncrementNumeric
            // 
            itemsIncrementNumeric.Location = new Point(327, 101);
            itemsIncrementNumeric.Name = "itemsIncrementNumeric";
            itemsIncrementNumeric.Size = new Size(51, 23);
            itemsIncrementNumeric.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 74);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 12;
            label4.Text = "Capacidade intervalo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 103);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 13;
            label5.Text = "Itens intervalo:";
            // 
            // performanceChart
            // 
            chartArea1.AxisX.Title = "Número de Itens";
            chartArea1.AxisY.Title = "Tempo (ms)";
            chartArea1.Name = "ChartArea1";
            performanceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            performanceChart.Legends.Add(legend1);
            performanceChart.Location = new Point(12, 130);
            performanceChart.Name = "performanceChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "ExecutionTime";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "FittedCurve";
            performanceChart.Series.Add(series1);
            performanceChart.Series.Add(series2);
            performanceChart.Size = new Size(753, 558);
            performanceChart.TabIndex = 14;
            performanceChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Grafico de performance";
            performanceChart.Titles.Add(title1);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(782, 148);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 15;
            label6.Text = "Complexidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(951, 148);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 17;
            label7.Text = "Assintotico:";
            // 
            // executeButton
            // 
            executeButton.Location = new Point(690, 16);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(75, 23);
            executeButton.TabIndex = 19;
            executeButton.Text = "Executar";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.MenuText;
            richTextBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(771, 566);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(557, 122);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // complexityLabel
            // 
            complexityLabel.AutoSize = true;
            complexityLabel.Location = new Point(874, 148);
            complexityLabel.Name = "complexityLabel";
            complexityLabel.Size = new Size(38, 15);
            complexityLabel.TabIndex = 21;
            complexityLabel.Text = "label8";
            // 
            // asymptoticBehaviorLabel
            // 
            asymptoticBehaviorLabel.AutoSize = true;
            asymptoticBehaviorLabel.Location = new Point(1026, 148);
            asymptoticBehaviorLabel.Name = "asymptoticBehaviorLabel";
            asymptoticBehaviorLabel.Size = new Size(38, 15);
            asymptoticBehaviorLabel.TabIndex = 22;
            asymptoticBehaviorLabel.Text = "label8";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 700);
            Controls.Add(asymptoticBehaviorLabel);
            Controls.Add(complexityLabel);
            Controls.Add(richTextBox1);
            Controls.Add(executeButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(performanceChart);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(capacityIncrementNumeric);
            Controls.Add(itemsIncrementNumeric);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultsDataGridView);
            Controls.Add(initialCapacityNumeric);
            Controls.Add(executionCountNumeric);
            Controls.Add(initialItemsNumeric);
            Controls.Add(exePathTextBox);
            Controls.Add(selectExeButton);
            Name = "mainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)initialItemsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)executionCountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCapacityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)capacityIncrementNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsIncrementNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)performanceChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectExeButton;
        private TextBox exePathTextBox;
        private NumericUpDown initialItemsNumeric;
        private NumericUpDown executionCountNumeric;
        private NumericUpDown initialCapacityNumeric;
        private DataGridView resultsDataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown capacityIncrementNumeric;
        private NumericUpDown itemsIncrementNumeric;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart performanceChart;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn colInstance;
        private DataGridViewTextBoxColumn colItems;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colMemory;
        private DataGridViewTextBoxColumn colExpectedValue;
        private DataGridViewTextBoxColumn colSolutionValue;
        private Button executeButton;
        private RichTextBox richTextBox1;
        private Label complexityLabel;
        private Label asymptoticBehaviorLabel;
    }
}
