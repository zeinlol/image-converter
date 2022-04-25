using System.ComponentModel;

namespace image_converter
{
    partial class FifthLab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.linesColorModal = new System.Windows.Forms.ColorDialog();
            this.backButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.processButton = new System.Windows.Forms.Button();
            this.correctionGroupBox = new System.Windows.Forms.GroupBox();
            this.medianGreyCorrection = new System.Windows.Forms.Button();
            this.lineHistogramCorrectionButton = new System.Windows.Forms.Button();
            this.resetInput = new System.Windows.Forms.Button();
            this.brightnesValueText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.greenMaxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.greenMinTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.blueMaxTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.blueMinTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.redMaxTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.redMinTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.greenChanelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.blueChanelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.redChanelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            this.correctionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChanelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChanelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChanelChart)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG|*.jpg|JPG|*.jpg;*.jpeg|BMP|*.bmp ";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "generated_image";
            this.saveFileDialog.Filter = "JPEG|*.jpg|JPG|*.jpg;*.jpeg|BMP|*.bmp ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(199, 28);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to main menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(566, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(199, 28);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(771, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(199, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // originalPicture
            // 
            this.originalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPicture.Location = new System.Drawing.Point(12, 46);
            this.originalPicture.Name = "originalPicture";
            this.originalPicture.Size = new System.Drawing.Size(554, 355);
            this.originalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPicture.TabIndex = 5;
            this.originalPicture.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(741, 24);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(199, 28);
            this.processButton.TabIndex = 20;
            this.processButton.Text = "Change brightness";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // correctionGroupBox
            // 
            this.correctionGroupBox.Controls.Add(this.medianGreyCorrection);
            this.correctionGroupBox.Controls.Add(this.lineHistogramCorrectionButton);
            this.correctionGroupBox.Controls.Add(this.resetInput);
            this.correctionGroupBox.Controls.Add(this.brightnesValueText);
            this.correctionGroupBox.Controls.Add(this.label7);
            this.correctionGroupBox.Controls.Add(this.brightnessTrackBar);
            this.correctionGroupBox.Controls.Add(this.processButton);
            this.correctionGroupBox.Controls.Add(this.greenMaxTextBox);
            this.correctionGroupBox.Controls.Add(this.label5);
            this.correctionGroupBox.Controls.Add(this.greenMinTextBox);
            this.correctionGroupBox.Controls.Add(this.label6);
            this.correctionGroupBox.Controls.Add(this.blueMaxTextBox);
            this.correctionGroupBox.Controls.Add(this.label3);
            this.correctionGroupBox.Controls.Add(this.blueMinTextBox);
            this.correctionGroupBox.Controls.Add(this.label4);
            this.correctionGroupBox.Controls.Add(this.redMaxTextBox);
            this.correctionGroupBox.Controls.Add(this.label2);
            this.correctionGroupBox.Controls.Add(this.redMinTextBox);
            this.correctionGroupBox.Controls.Add(this.label1);
            this.correctionGroupBox.Location = new System.Drawing.Point(13, 407);
            this.correctionGroupBox.Name = "correctionGroupBox";
            this.correctionGroupBox.Size = new System.Drawing.Size(957, 104);
            this.correctionGroupBox.TabIndex = 21;
            this.correctionGroupBox.TabStop = false;
            this.correctionGroupBox.Text = "Line gistogram correction";
            // 
            // medianGreyCorrection
            // 
            this.medianGreyCorrection.Location = new System.Drawing.Point(536, 58);
            this.medianGreyCorrection.Name = "medianGreyCorrection";
            this.medianGreyCorrection.Size = new System.Drawing.Size(199, 28);
            this.medianGreyCorrection.TabIndex = 27;
            this.medianGreyCorrection.Text = "Median grey correction";
            this.medianGreyCorrection.UseVisualStyleBackColor = true;
            this.medianGreyCorrection.Click += new System.EventHandler(this.medianGreyCorrection_Click);
            // 
            // lineHistogramCorrectionButton
            // 
            this.lineHistogramCorrectionButton.Location = new System.Drawing.Point(536, 24);
            this.lineHistogramCorrectionButton.Name = "lineHistogramCorrectionButton";
            this.lineHistogramCorrectionButton.Size = new System.Drawing.Size(199, 28);
            this.lineHistogramCorrectionButton.TabIndex = 26;
            this.lineHistogramCorrectionButton.Text = "Line histogram correction";
            this.lineHistogramCorrectionButton.UseVisualStyleBackColor = true;
            this.lineHistogramCorrectionButton.Click += new System.EventHandler(this.lineHistogramCorrectionButton_Click);
            // 
            // resetInput
            // 
            this.resetInput.Location = new System.Drawing.Point(741, 58);
            this.resetInput.Name = "resetInput";
            this.resetInput.Size = new System.Drawing.Size(199, 28);
            this.resetInput.TabIndex = 25;
            this.resetInput.Text = "Reset";
            this.resetInput.UseVisualStyleBackColor = true;
            this.resetInput.Click += new System.EventHandler(this.resetInput_Click);
            // 
            // brightnesValueText
            // 
            this.brightnesValueText.Location = new System.Drawing.Point(407, 63);
            this.brightnesValueText.Name = "brightnesValueText";
            this.brightnesValueText.Size = new System.Drawing.Size(81, 20);
            this.brightnesValueText.TabIndex = 14;
            this.brightnesValueText.Text = "0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(320, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Brightnes:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.LargeChange = 20;
            this.brightnessTrackBar.Location = new System.Drawing.Point(320, 27);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = -100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(197, 56);
            this.brightnessTrackBar.SmallChange = 10;
            this.brightnessTrackBar.TabIndex = 12;
            this.brightnessTrackBar.TickFrequency = 10;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // greenMaxTextBox
            // 
            this.greenMaxTextBox.Location = new System.Drawing.Point(159, 55);
            this.greenMaxTextBox.MaxLength = 3;
            this.greenMaxTextBox.Name = "greenMaxTextBox";
            this.greenMaxTextBox.Size = new System.Drawing.Size(52, 22);
            this.greenMaxTextBox.TabIndex = 11;
            this.greenMaxTextBox.Text = "255";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(115, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gmax";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenMinTextBox
            // 
            this.greenMinTextBox.Location = new System.Drawing.Point(159, 27);
            this.greenMinTextBox.MaxLength = 3;
            this.greenMinTextBox.Name = "greenMinTextBox";
            this.greenMinTextBox.Size = new System.Drawing.Size(52, 22);
            this.greenMinTextBox.TabIndex = 9;
            this.greenMinTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(115, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gmin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blueMaxTextBox
            // 
            this.blueMaxTextBox.Location = new System.Drawing.Point(262, 55);
            this.blueMaxTextBox.MaxLength = 3;
            this.blueMaxTextBox.Name = "blueMaxTextBox";
            this.blueMaxTextBox.Size = new System.Drawing.Size(52, 22);
            this.blueMaxTextBox.TabIndex = 7;
            this.blueMaxTextBox.Text = "255";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(218, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bmax";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blueMinTextBox
            // 
            this.blueMinTextBox.Location = new System.Drawing.Point(262, 27);
            this.blueMinTextBox.MaxLength = 3;
            this.blueMinTextBox.Name = "blueMinTextBox";
            this.blueMinTextBox.Size = new System.Drawing.Size(52, 22);
            this.blueMinTextBox.TabIndex = 5;
            this.blueMinTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(218, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bmin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redMaxTextBox
            // 
            this.redMaxTextBox.Location = new System.Drawing.Point(57, 55);
            this.redMaxTextBox.MaxLength = 3;
            this.redMaxTextBox.Name = "redMaxTextBox";
            this.redMaxTextBox.Size = new System.Drawing.Size(52, 22);
            this.redMaxTextBox.TabIndex = 3;
            this.redMaxTextBox.Text = "255";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rmax";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redMinTextBox
            // 
            this.redMinTextBox.Location = new System.Drawing.Point(57, 27);
            this.redMinTextBox.MaxLength = 3;
            this.redMinTextBox.Name = "redMinTextBox";
            this.redMinTextBox.Size = new System.Drawing.Size(52, 22);
            this.redMinTextBox.TabIndex = 1;
            this.redMinTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rmin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenChanelChart
            // 
            this.greenChanelChart.AccessibleDescription = "";
            this.greenChanelChart.AccessibleName = "Green Chanel";
            chartArea1.Name = "ChartArea1";
            this.greenChanelChart.ChartAreas.Add(chartArea1);
            this.greenChanelChart.Location = new System.Drawing.Point(572, 165);
            this.greenChanelChart.Name = "greenChanelChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Green;
            series1.Name = "Series1";
            this.greenChanelChart.Series.Add(series1);
            this.greenChanelChart.Size = new System.Drawing.Size(398, 113);
            this.greenChanelChart.TabIndex = 23;
            this.greenChanelChart.Text = "Green Chanel";
            title1.Name = "Title1";
            title1.Text = "Green Chanel";
            this.greenChanelChart.Titles.Add(title1);
            // 
            // blueChanelChart
            // 
            this.blueChanelChart.AccessibleDescription = "";
            this.blueChanelChart.AccessibleName = "Green Chanel";
            chartArea2.Name = "ChartArea1";
            this.blueChanelChart.ChartAreas.Add(chartArea2);
            this.blueChanelChart.Location = new System.Drawing.Point(572, 288);
            this.blueChanelChart.Name = "blueChanelChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "Series1";
            this.blueChanelChart.Series.Add(series2);
            this.blueChanelChart.Size = new System.Drawing.Size(398, 113);
            this.blueChanelChart.TabIndex = 24;
            this.blueChanelChart.Text = "Green Chanel";
            title2.Name = "Title1";
            title2.Text = "Blue Chanel";
            this.blueChanelChart.Titles.Add(title2);
            // 
            // redChanelChart
            // 
            this.redChanelChart.AccessibleDescription = "";
            this.redChanelChart.AccessibleName = "Blue Chanel";
            chartArea3.Name = "ChartArea1";
            this.redChanelChart.ChartAreas.Add(chartArea3);
            this.redChanelChart.Location = new System.Drawing.Point(572, 46);
            this.redChanelChart.Name = "redChanelChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.Red;
            series3.Name = "Series1";
            this.redChanelChart.Series.Add(series3);
            this.redChanelChart.Size = new System.Drawing.Size(398, 113);
            this.redChanelChart.TabIndex = 25;
            this.redChanelChart.Text = "Red Chanel";
            title3.Name = "Title1";
            title3.Text = "Red Chanel";
            this.redChanelChart.Titles.Add(title3);
            // 
            // FifthLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 523);
            this.Controls.Add(this.redChanelChart);
            this.Controls.Add(this.blueChanelChart);
            this.Controls.Add(this.greenChanelChart);
            this.Controls.Add(this.correctionGroupBox);
            this.Controls.Add(this.originalPicture);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.backButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(1000, 570);
            this.Name = "FifthLab";
            this.Text = "Fifth Lab";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            this.correctionGroupBox.ResumeLayout(false);
            this.correctionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChanelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChanelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChanelChart)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button medianGreyCorrection;

        private System.Windows.Forms.Button lineHistogramCorrectionButton;

        private System.Windows.Forms.Button resetInput;

        private System.Windows.Forms.Label brightnesValueText;

        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox blueMaxTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox blueMinTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox greenMaxTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox greenMinTextBox;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox redMaxTextBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox redMinTextBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataVisualization.Charting.Chart blueChanelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart greenChanelChart;

        private System.Windows.Forms.DataVisualization.Charting.Chart redChanelChart;

        private System.Windows.Forms.GroupBox correctionGroupBox;

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox originalPicture;
        private System.Windows.Forms.Button processButton;

        private System.Windows.Forms.ColorDialog linesColorModal;

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        #endregion
    }
}