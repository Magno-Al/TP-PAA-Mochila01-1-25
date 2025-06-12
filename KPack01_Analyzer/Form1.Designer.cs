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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            maxValueNumeric = new NumericUpDown();
            minValueNumeric = new NumericUpDown();
            maxWeightNumeric = new NumericUpDown();
            minWeightNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)initialItemsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)executionCountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCapacityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capacityIncrementNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsIncrementNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)performanceChart).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxValueNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minValueNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxWeightNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minWeightNumeric).BeginInit();
            SuspendLayout();
            // 
            // selectExeButton
            // 
            selectExeButton.Location = new Point(14, 16);
            selectExeButton.Margin = new Padding(3, 4, 3, 4);
            selectExeButton.Name = "selectExeButton";
            selectExeButton.Size = new Size(155, 31);
            selectExeButton.TabIndex = 0;
            selectExeButton.Text = "Selecionar algoritmo";
            selectExeButton.UseVisualStyleBackColor = true;
            selectExeButton.Click += selectExeButton_Click;
            // 
            // exePathTextBox
            // 
            exePathTextBox.Location = new Point(176, 16);
            exePathTextBox.Margin = new Padding(3, 4, 3, 4);
            exePathTextBox.Name = "exePathTextBox";
            exePathTextBox.ReadOnly = true;
            exePathTextBox.Size = new Size(517, 27);
            exePathTextBox.TabIndex = 1;
            // 
            // initialItemsNumeric
            // 
            initialItemsNumeric.Location = new Point(82, 21);
            initialItemsNumeric.Margin = new Padding(3, 4, 3, 4);
            initialItemsNumeric.Name = "initialItemsNumeric";
            initialItemsNumeric.Size = new Size(58, 27);
            initialItemsNumeric.TabIndex = 3;
            // 
            // executionCountNumeric
            // 
            executionCountNumeric.Location = new Point(701, 19);
            executionCountNumeric.Margin = new Padding(3, 4, 3, 4);
            executionCountNumeric.Name = "executionCountNumeric";
            executionCountNumeric.Size = new Size(58, 27);
            executionCountNumeric.TabIndex = 4;
            // 
            // initialCapacityNumeric
            // 
            initialCapacityNumeric.Location = new Point(82, 25);
            initialCapacityNumeric.Margin = new Padding(3, 4, 3, 4);
            initialCapacityNumeric.Name = "initialCapacityNumeric";
            initialCapacityNumeric.Size = new Size(58, 27);
            initialCapacityNumeric.TabIndex = 5;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { colInstance, colItems, colCapacity, colTime, colMemory, colExpectedValue, colSolutionValue });
            resultsDataGridView.Location = new Point(881, 241);
            resultsDataGridView.Margin = new Padding(3, 4, 3, 4);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.ReadOnly = true;
            resultsDataGridView.RowHeadersWidth = 51;
            resultsDataGridView.Size = new Size(637, 505);
            resultsDataGridView.TabIndex = 6;
            // 
            // colInstance
            // 
            colInstance.HeaderText = "Instância";
            colInstance.MinimumWidth = 6;
            colInstance.Name = "colInstance";
            colInstance.ReadOnly = true;
            // 
            // colItems
            // 
            colItems.HeaderText = "Itens";
            colItems.MinimumWidth = 6;
            colItems.Name = "colItems";
            colItems.ReadOnly = true;
            // 
            // colCapacity
            // 
            colCapacity.HeaderText = "Capacidade";
            colCapacity.MinimumWidth = 6;
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.HeaderText = "Tempo (ms)";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colMemory
            // 
            colMemory.HeaderText = "Maior memoria";
            colMemory.MinimumWidth = 6;
            colMemory.Name = "colMemory";
            colMemory.ReadOnly = true;
            // 
            // colExpectedValue
            // 
            colExpectedValue.HeaderText = "Valor esperado";
            colExpectedValue.MinimumWidth = 6;
            colExpectedValue.Name = "colExpectedValue";
            colExpectedValue.ReadOnly = true;
            // 
            // colSolutionValue
            // 
            colSolutionValue.HeaderText = "Valor Solução";
            colSolutionValue.MinimumWidth = 6;
            colSolutionValue.Name = "colSolutionValue";
            colSolutionValue.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 7;
            label1.Text = "Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Inicial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 27);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 9;
            label3.Text = "X";
            // 
            // capacityIncrementNumeric
            // 
            capacityIncrementNumeric.Location = new Point(82, 62);
            capacityIncrementNumeric.Margin = new Padding(3, 4, 3, 4);
            capacityIncrementNumeric.Name = "capacityIncrementNumeric";
            capacityIncrementNumeric.Size = new Size(58, 27);
            capacityIncrementNumeric.TabIndex = 11;
            // 
            // itemsIncrementNumeric
            // 
            itemsIncrementNumeric.Location = new Point(82, 60);
            itemsIncrementNumeric.Margin = new Padding(3, 4, 3, 4);
            itemsIncrementNumeric.Name = "itemsIncrementNumeric";
            itemsIncrementNumeric.Size = new Size(58, 27);
            itemsIncrementNumeric.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 62);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Intervalo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 62);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "Intervalo:";
            // 
            // performanceChart
            // 
            chartArea1.AxisX.Title = "Número de Itens";
            chartArea1.AxisY.Title = "Tempo (ms)";
            chartArea1.Name = "ChartArea1";
            performanceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            performanceChart.Legends.Add(legend1);
            performanceChart.Location = new Point(14, 173);
            performanceChart.Margin = new Padding(3, 4, 3, 4);
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
            performanceChart.Size = new Size(861, 744);
            performanceChart.TabIndex = 14;
            performanceChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Grafico de performance";
            performanceChart.Titles.Add(title1);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(894, 197);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 15;
            label6.Text = "Complexidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1213, 197);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 17;
            label7.Text = "Assintotico:";
            // 
            // executeButton
            // 
            executeButton.Location = new Point(789, 21);
            executeButton.Margin = new Padding(3, 4, 3, 4);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(86, 31);
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
            richTextBox1.Location = new Point(881, 755);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(636, 161);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // complexityLabel
            // 
            complexityLabel.AutoSize = true;
            complexityLabel.Location = new Point(999, 197);
            complexityLabel.Name = "complexityLabel";
            complexityLabel.Size = new Size(50, 20);
            complexityLabel.TabIndex = 21;
            complexityLabel.Text = "label8";
            // 
            // asymptoticBehaviorLabel
            // 
            asymptoticBehaviorLabel.AutoSize = true;
            asymptoticBehaviorLabel.Location = new Point(1304, 197);
            asymptoticBehaviorLabel.Name = "asymptoticBehaviorLabel";
            asymptoticBehaviorLabel.Size = new Size(50, 20);
            asymptoticBehaviorLabel.TabIndex = 22;
            asymptoticBehaviorLabel.Text = "label8";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(initialCapacityNumeric);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(capacityIncrementNumeric);
            groupBox1.Location = new Point(14, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 102);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capacidade";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(maxValueNumeric);
            groupBox2.Controls.Add(minValueNumeric);
            groupBox2.Controls.Add(maxWeightNumeric);
            groupBox2.Controls.Add(minWeightNumeric);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(initialItemsNumeric);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(itemsIncrementNumeric);
            groupBox2.Location = new Point(270, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 102);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(302, 64);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 21;
            label11.Text = "a";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(302, 27);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 20;
            label10.Text = "a";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 64);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 19;
            label9.Text = "Valor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(168, 25);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 18;
            label8.Text = "Peso:";
            // 
            // maxValueNumeric
            // 
            maxValueNumeric.Location = new Point(325, 62);
            maxValueNumeric.Name = "maxValueNumeric";
            maxValueNumeric.Size = new Size(58, 27);
            maxValueNumeric.TabIndex = 17;
            // 
            // minValueNumeric
            // 
            minValueNumeric.Location = new Point(228, 60);
            minValueNumeric.Name = "minValueNumeric";
            minValueNumeric.Size = new Size(58, 27);
            minValueNumeric.TabIndex = 16;
            // 
            // maxWeightNumeric
            // 
            maxWeightNumeric.Location = new Point(325, 21);
            maxWeightNumeric.Name = "maxWeightNumeric";
            maxWeightNumeric.Size = new Size(58, 27);
            maxWeightNumeric.TabIndex = 15;
            // 
            // minWeightNumeric
            // 
            minWeightNumeric.Location = new Point(228, 21);
            minWeightNumeric.Name = "minWeightNumeric";
            minWeightNumeric.Size = new Size(58, 27);
            minWeightNumeric.TabIndex = 14;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 933);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(asymptoticBehaviorLabel);
            Controls.Add(complexityLabel);
            Controls.Add(richTextBox1);
            Controls.Add(executeButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(performanceChart);
            Controls.Add(label3);
            Controls.Add(resultsDataGridView);
            Controls.Add(executionCountNumeric);
            Controls.Add(exePathTextBox);
            Controls.Add(selectExeButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)initialItemsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)executionCountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCapacityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)capacityIncrementNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsIncrementNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)performanceChart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxValueNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)minValueNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxWeightNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)minWeightNumeric).EndInit();
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private NumericUpDown maxValueNumeric;
        private NumericUpDown minValueNumeric;
        private NumericUpDown maxWeightNumeric;
        private NumericUpDown minWeightNumeric;
    }
}
