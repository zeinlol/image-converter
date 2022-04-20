using System.ComponentModel;

namespace image_converter
{
    partial class SecondLab
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
            this.backButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.generatedPicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.redTrackBarValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.greenTrackBarValue = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.labelBtrack = new System.Windows.Forms.Label();
            this.blueTrackBarValue = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.resetWeightsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            this.SuspendLayout();
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
            this.openFile.Location = new System.Drawing.Point(217, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(199, 28);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(422, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(199, 28);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(627, 12);
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
            this.originalPicture.Size = new System.Drawing.Size(404, 228);
            this.originalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPicture.TabIndex = 5;
            this.originalPicture.TabStop = false;
            // 
            // generatedPicture
            // 
            this.generatedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedPicture.Location = new System.Drawing.Point(422, 46);
            this.generatedPicture.Name = "generatedPicture";
            this.generatedPicture.Size = new System.Drawing.Size(404, 228);
            this.generatedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generatedPicture.TabIndex = 6;
            this.generatedPicture.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG|*.jpg|JPG|*.jpg;*.jpeg|BMP|*.bmp ";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "generated_grey_image";
            this.saveFileDialog.Filter = "JPEG|*.jpg|JPG|*.jpg;*.jpeg|BMP|*.bmp ";
            // 
            // redTrackBar
            // 
            this.redTrackBar.AccessibleDescription = "Red Chanel";
            this.redTrackBar.AccessibleName = "Red";
            this.redTrackBar.Location = new System.Drawing.Point(27, 289);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(252, 56);
            this.redTrackBar.TabIndex = 10;
            this.redTrackBar.TickFrequency = 10;
            this.redTrackBar.Value = 77;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // redTrackBarValue
            // 
            this.redTrackBarValue.Location = new System.Drawing.Point(27, 322);
            this.redTrackBarValue.Name = "redTrackBarValue";
            this.redTrackBarValue.Size = new System.Drawing.Size(252, 23);
            this.redTrackBarValue.TabIndex = 11;
            this.redTrackBarValue.Text = "77";
            this.redTrackBarValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-4, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(271, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "G";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenTrackBarValue
            // 
            this.greenTrackBarValue.Location = new System.Drawing.Point(302, 322);
            this.greenTrackBarValue.Name = "greenTrackBarValue";
            this.greenTrackBarValue.Size = new System.Drawing.Size(252, 23);
            this.greenTrackBarValue.TabIndex = 14;
            this.greenTrackBarValue.Text = "150";
            this.greenTrackBarValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.AccessibleDescription = "Red Chanel";
            this.greenTrackBar.AccessibleName = "Red";
            this.greenTrackBar.Location = new System.Drawing.Point(302, 289);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(252, 56);
            this.greenTrackBar.TabIndex = 13;
            this.greenTrackBar.TickFrequency = 10;
            this.greenTrackBar.Value = 77;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // labelBtrack
            // 
            this.labelBtrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBtrack.ForeColor = System.Drawing.Color.Blue;
            this.labelBtrack.Location = new System.Drawing.Point(543, 289);
            this.labelBtrack.Name = "labelBtrack";
            this.labelBtrack.Size = new System.Drawing.Size(38, 28);
            this.labelBtrack.TabIndex = 15;
            this.labelBtrack.Text = "B";
            this.labelBtrack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blueTrackBarValue
            // 
            this.blueTrackBarValue.Location = new System.Drawing.Point(574, 322);
            this.blueTrackBarValue.Name = "blueTrackBarValue";
            this.blueTrackBarValue.Size = new System.Drawing.Size(252, 23);
            this.blueTrackBarValue.TabIndex = 17;
            this.blueTrackBarValue.Text = "29";
            this.blueTrackBarValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.AccessibleDescription = "Red Chanel";
            this.blueTrackBar.AccessibleName = "Red";
            this.blueTrackBar.Location = new System.Drawing.Point(574, 289);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(252, 56);
            this.blueTrackBar.TabIndex = 16;
            this.blueTrackBar.TickFrequency = 10;
            this.blueTrackBar.Value = 29;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // resetWeightsButton
            // 
            this.resetWeightsButton.Location = new System.Drawing.Point(12, 348);
            this.resetWeightsButton.Name = "resetWeightsButton";
            this.resetWeightsButton.Size = new System.Drawing.Size(199, 28);
            this.resetWeightsButton.TabIndex = 18;
            this.resetWeightsButton.Text = "Reset Weights";
            this.resetWeightsButton.UseVisualStyleBackColor = true;
            this.resetWeightsButton.Click += new System.EventHandler(this.resetWeightsButton_Click);
            // 
            // SecondLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(845, 392);
            this.Controls.Add(this.resetWeightsButton);
            this.Controls.Add(this.labelBtrack);
            this.Controls.Add(this.blueTrackBarValue);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.greenTrackBarValue);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redTrackBarValue);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.generatedPicture);
            this.Controls.Add(this.originalPicture);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.backButton);
            this.MaximumSize = new System.Drawing.Size(863, 439);
            this.Name = "SecondLab";
            this.Text = "SecondLab";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button resetWeightsButton;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Label labelBtrack;
        private System.Windows.Forms.Label blueTrackBarValue;
        private System.Windows.Forms.TrackBar blueTrackBar;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label redTrackBarValue;
        private System.Windows.Forms.Label greenTrackBarValue;

        private System.Windows.Forms.TrackBar redTrackBar;

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.PictureBox generatedPicture;

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox originalPicture;

        private System.Windows.Forms.Button openFile;

        private System.Windows.Forms.Button backButton;

        #endregion
    }
}