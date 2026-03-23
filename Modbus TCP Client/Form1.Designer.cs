namespace Modbus_TCP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.distanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pauseButton = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startAddressTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abortButton = new System.Windows.Forms.Button();
            this.okLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.startAdressLabel = new System.Windows.Forms.Label();
            this.startAdressTextBox = new System.Windows.Forms.TextBox();
            this.distanceChartPanel = new System.Windows.Forms.Panel();
            this.speedChartPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.distanceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.distanceChartPanel.SuspendLayout();
            this.speedChartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 212);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 50);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // distanceChart
            // 
            chartArea1.AxisX.Title = "t";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "S";
            chartArea1.Name = "ChartArea1";
            this.distanceChart.ChartAreas.Add(chartArea1);
            this.distanceChart.Location = new System.Drawing.Point(0, 0);
            this.distanceChart.Name = "distanceChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelToolTip = "#VALX{H:mm:ss}";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.distanceChart.Series.Add(series1);
            this.distanceChart.Size = new System.Drawing.Size(960, 270);
            this.distanceChart.TabIndex = 1;
            this.distanceChart.Text = "chart1";
            // 
            // speedChart
            // 
            chartArea2.AxisX.Title = "t";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.Title = "V";
            chartArea2.Name = "ChartArea1";
            this.speedChart.ChartAreas.Add(chartArea2);
            this.speedChart.Location = new System.Drawing.Point(0, 0);
            this.speedChart.Name = "speedChart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelToolTip = "#VALX{H:mm:ss}";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            this.speedChart.Series.Add(series2);
            this.speedChart.Size = new System.Drawing.Size(960, 270);
            this.speedChart.TabIndex = 2;
            this.speedChart.Text = "chart1";
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(15, 268);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(200, 50);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(8, 41);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(122, 20);
            this.ipTextBox.TabIndex = 5;
            this.ipTextBox.Text = "127.0.0.1";
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ipLabel
            // 
            this.ipLabel.Location = new System.Drawing.Point(15, 21);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(115, 17);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "IP address";
            this.ipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(147, 41);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(74, 20);
            this.portTextBox.TabIndex = 7;
            this.portTextBox.Text = "502";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // portLabel
            // 
            this.portLabel.Location = new System.Drawing.Point(184, 21);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(37, 17);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Port";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startAddressTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.abortButton);
            this.groupBox1.Controls.Add(this.okLabel);
            this.groupBox1.Controls.Add(this.intervalLabel);
            this.groupBox1.Controls.Add(this.intervalTextBox);
            this.groupBox1.Controls.Add(this.startAdressLabel);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.startAdressTextBox);
            this.groupBox1.Controls.Add(this.ipTextBox);
            this.groupBox1.Controls.Add(this.portLabel);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.ipLabel);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1012, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 389);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management";
            // 
            // startAddressTextBox
            // 
            this.startAddressTextBox.Location = new System.Drawing.Point(147, 80);
            this.startAddressTextBox.Name = "startAddressTextBox";
            this.startAddressTextBox.Size = new System.Drawing.Size(74, 17);
            this.startAddressTextBox.TabIndex = 15;
            this.startAddressTextBox.Text = "Start address";
            this.startAddressTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Interval (s)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // abortButton
            // 
            this.abortButton.Enabled = false;
            this.abortButton.Location = new System.Drawing.Point(15, 324);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(200, 50);
            this.abortButton.TabIndex = 13;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // okLabel
            // 
            this.okLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okLabel.Location = new System.Drawing.Point(56, 137);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(116, 45);
            this.okLabel.TabIndex = 12;
            this.okLabel.Text = "OK!";
            this.okLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okLabel.Visible = false;
            // 
            // intervalLabel
            // 
            this.intervalLabel.Location = new System.Drawing.Point(43, 80);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(87, 16);
            this.intervalLabel.TabIndex = 12;
            this.intervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(56, 99);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(74, 20);
            this.intervalTextBox.TabIndex = 11;
            this.intervalTextBox.Text = "1";
            this.intervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startAdressLabel
            // 
            this.startAdressLabel.Location = new System.Drawing.Point(147, 80);
            this.startAdressLabel.Name = "startAdressLabel";
            this.startAdressLabel.Size = new System.Drawing.Size(74, 16);
            this.startAdressLabel.TabIndex = 10;
            this.startAdressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startAdressTextBox
            // 
            this.startAdressTextBox.Location = new System.Drawing.Point(147, 99);
            this.startAdressTextBox.Name = "startAdressTextBox";
            this.startAdressTextBox.Size = new System.Drawing.Size(74, 20);
            this.startAdressTextBox.TabIndex = 9;
            this.startAdressTextBox.Text = "0";
            this.startAdressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // distanceChartPanel
            // 
            this.distanceChartPanel.AutoScroll = true;
            this.distanceChartPanel.Controls.Add(this.distanceChart);
            this.distanceChartPanel.Location = new System.Drawing.Point(10, 12);
            this.distanceChartPanel.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.distanceChartPanel.Name = "distanceChartPanel";
            this.distanceChartPanel.Size = new System.Drawing.Size(960, 290);
            this.distanceChartPanel.TabIndex = 10;
            // 
            // speedChartPanel
            // 
            this.speedChartPanel.AutoScroll = true;
            this.speedChartPanel.Controls.Add(this.speedChart);
            this.speedChartPanel.Location = new System.Drawing.Point(12, 298);
            this.speedChartPanel.Name = "speedChartPanel";
            this.speedChartPanel.Size = new System.Drawing.Size(960, 290);
            this.speedChartPanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 600);
            this.Controls.Add(this.speedChartPanel);
            this.Controls.Add(this.distanceChartPanel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modbus TCP Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.distanceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.distanceChartPanel.ResumeLayout(false);
            this.speedChartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label startAddressTextBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button abortButton;

        private System.Windows.Forms.Panel distanceChartPanel;
        private System.Windows.Forms.Panel speedChartPanel;

        private System.Windows.Forms.Label okLabel;

        private System.Windows.Forms.Label intervalLabel;

        private System.Windows.Forms.TextBox intervalTextBox;

        private System.Windows.Forms.Label startAdressLabel;
        private System.Windows.Forms.TextBox startAdressTextBox;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label portLabel;

        private System.Windows.Forms.TextBox ipTextBox;

        private System.Windows.Forms.Label ipLabel;

        private System.Windows.Forms.TextBox portTextBox;

        private System.Windows.Forms.Button pauseButton;

        private System.Windows.Forms.DataVisualization.Charting.Chart speedChart;

        private System.Windows.Forms.DataVisualization.Charting.Chart distanceChart;

        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.Button startButton;
    }
}