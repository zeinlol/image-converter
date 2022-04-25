using System.ComponentModel;

namespace image_converter
{
    partial class SixthLab
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.linesColorModal = new System.Windows.Forms.ColorDialog();
            this.backButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.originalPicture = new System.Windows.Forms.PictureBox();
            this.processButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.threeRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.fiveRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.sevenRangeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
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
            this.openFile.Location = new System.Drawing.Point(448, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(170, 28);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(800, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 28);
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
            this.originalPicture.Size = new System.Drawing.Size(475, 297);
            this.originalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPicture.TabIndex = 5;
            this.originalPicture.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(624, 12);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(170, 28);
            this.processButton.TabIndex = 20;
            this.processButton.Text = "Run filtration";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(495, 46);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(475, 297);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 22;
            this.resultPictureBox.TabStop = false;
            // 
            // threeRangeCheckBox
            // 
            this.threeRangeCheckBox.Checked = true;
            this.threeRangeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threeRangeCheckBox.Location = new System.Drawing.Point(217, 13);
            this.threeRangeCheckBox.Name = "threeRangeCheckBox";
            this.threeRangeCheckBox.Size = new System.Drawing.Size(70, 28);
            this.threeRangeCheckBox.TabIndex = 26;
            this.threeRangeCheckBox.Text = "3 x 3";
            this.threeRangeCheckBox.UseVisualStyleBackColor = true;
            this.threeRangeCheckBox.CheckedChanged += new System.EventHandler(this.threeRangeCheckBox_CheckedChanged);
            // 
            // fiveRangeCheckBox
            // 
            this.fiveRangeCheckBox.Location = new System.Drawing.Point(293, 13);
            this.fiveRangeCheckBox.Name = "fiveRangeCheckBox";
            this.fiveRangeCheckBox.Size = new System.Drawing.Size(70, 28);
            this.fiveRangeCheckBox.TabIndex = 27;
            this.fiveRangeCheckBox.Text = "5 x 5";
            this.fiveRangeCheckBox.UseVisualStyleBackColor = true;
            this.fiveRangeCheckBox.CheckedChanged += new System.EventHandler(this.fiveRangeCheckBox_CheckedChanged);
            // 
            // sevenRangeCheckBox
            // 
            this.sevenRangeCheckBox.Location = new System.Drawing.Point(369, 13);
            this.sevenRangeCheckBox.Name = "sevenRangeCheckBox";
            this.sevenRangeCheckBox.Size = new System.Drawing.Size(70, 28);
            this.sevenRangeCheckBox.TabIndex = 28;
            this.sevenRangeCheckBox.Text = "7 x 7";
            this.sevenRangeCheckBox.UseVisualStyleBackColor = true;
            this.sevenRangeCheckBox.CheckedChanged += new System.EventHandler(this.sevenRangeCheckBox_CheckedChanged);
            // 
            // SixthLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 355);
            this.Controls.Add(this.sevenRangeCheckBox);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.fiveRangeCheckBox);
            this.Controls.Add(this.threeRangeCheckBox);
            this.Controls.Add(this.originalPicture);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.backButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(1000, 570);
            this.Name = "SixthLab";
            this.Text = "Sixth Lab";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.CheckBox threeRangeCheckBox;
        private System.Windows.Forms.CheckBox fiveRangeCheckBox;
        private System.Windows.Forms.CheckBox sevenRangeCheckBox;

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