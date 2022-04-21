using System.ComponentModel;

namespace image_converter
{
    partial class FourthLab
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
            this.generatedPicture = new System.Windows.Forms.PictureBox();
            this.rotateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rotateTextBox = new System.Windows.Forms.TextBox();
            this.rotateGroupBox = new System.Windows.Forms.GroupBox();
            this.invertButton = new System.Windows.Forms.Button();
            this.mirrorVerticalButton = new System.Windows.Forms.Button();
            this.mirrorHorizontalButton = new System.Windows.Forms.Button();
            this.mirrorGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inclineYArgTrackBar = new System.Windows.Forms.TrackBar();
            this.generateInclineEffect = new System.Windows.Forms.Button();
            this.resetInclineData = new System.Windows.Forms.Button();
            this.inclineYArgValue = new System.Windows.Forms.Label();
            this.inclineEffectGroup = new System.Windows.Forms.GroupBox();
            this.inclineXArgValue = new System.Windows.Forms.Label();
            this.inclineXArgTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedPicture)).BeginInit();
            this.rotateGroupBox.SuspendLayout();
            this.mirrorGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclineYArgTrackBar)).BeginInit();
            this.inclineEffectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclineXArgTrackBar)).BeginInit();
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
            this.openFile.Location = new System.Drawing.Point(217, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(199, 28);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openButton_Click);
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
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(6, 80);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(211, 28);
            this.rotateButton.TabIndex = 3;
            this.rotateButton.Text = "Generate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rotate Angle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rotateTextBox
            // 
            this.rotateTextBox.Location = new System.Drawing.Point(117, 24);
            this.rotateTextBox.MaxLength = 3;
            this.rotateTextBox.Name = "rotateTextBox";
            this.rotateTextBox.Size = new System.Drawing.Size(100, 22);
            this.rotateTextBox.TabIndex = 23;
            this.rotateTextBox.Text = "0";
            this.rotateTextBox.TextChanged += new System.EventHandler(this.rotateTextBox_TextChanged);
            // 
            // rotateGroupBox
            // 
            this.rotateGroupBox.Controls.Add(this.rotateTextBox);
            this.rotateGroupBox.Controls.Add(this.label1);
            this.rotateGroupBox.Controls.Add(this.rotateButton);
            this.rotateGroupBox.Location = new System.Drawing.Point(12, 280);
            this.rotateGroupBox.Name = "rotateGroupBox";
            this.rotateGroupBox.Size = new System.Drawing.Size(228, 114);
            this.rotateGroupBox.TabIndex = 19;
            this.rotateGroupBox.TabStop = false;
            this.rotateGroupBox.Text = "Rotate";
            // 
            // invertButton
            // 
            this.invertButton.Location = new System.Drawing.Point(422, 12);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(199, 28);
            this.invertButton.TabIndex = 20;
            this.invertButton.Text = "Invert";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // mirrorVerticalButton
            // 
            this.mirrorVerticalButton.Location = new System.Drawing.Point(6, 21);
            this.mirrorVerticalButton.Name = "mirrorVerticalButton";
            this.mirrorVerticalButton.Size = new System.Drawing.Size(199, 28);
            this.mirrorVerticalButton.TabIndex = 3;
            this.mirrorVerticalButton.Text = "Vertical";
            this.mirrorVerticalButton.UseVisualStyleBackColor = true;
            this.mirrorVerticalButton.Click += new System.EventHandler(this.mirrorVerticalButton_Click);
            // 
            // mirrorHorizontalButton
            // 
            this.mirrorHorizontalButton.Location = new System.Drawing.Point(10, 80);
            this.mirrorHorizontalButton.Name = "mirrorHorizontalButton";
            this.mirrorHorizontalButton.Size = new System.Drawing.Size(199, 28);
            this.mirrorHorizontalButton.TabIndex = 4;
            this.mirrorHorizontalButton.Text = "Horizontal";
            this.mirrorHorizontalButton.UseVisualStyleBackColor = true;
            this.mirrorHorizontalButton.Click += new System.EventHandler(this.mirrorHorizontalButton_Click);
            // 
            // mirrorGroup
            // 
            this.mirrorGroup.Controls.Add(this.mirrorHorizontalButton);
            this.mirrorGroup.Controls.Add(this.mirrorVerticalButton);
            this.mirrorGroup.Location = new System.Drawing.Point(246, 280);
            this.mirrorGroup.Name = "mirrorGroup";
            this.mirrorGroup.Size = new System.Drawing.Size(215, 114);
            this.mirrorGroup.TabIndex = 20;
            this.mirrorGroup.TabStop = false;
            this.mirrorGroup.Text = "Mirror";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(169, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inclineYArgTrackBar
            // 
            this.inclineYArgTrackBar.AccessibleDescription = "Red Chanel";
            this.inclineYArgTrackBar.AccessibleName = "Red";
            this.inclineYArgTrackBar.LargeChange = 2;
            this.inclineYArgTrackBar.Location = new System.Drawing.Point(200, 18);
            this.inclineYArgTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.inclineYArgTrackBar.Minimum = 1;
            this.inclineYArgTrackBar.Name = "inclineYArgTrackBar";
            this.inclineYArgTrackBar.Size = new System.Drawing.Size(142, 56);
            this.inclineYArgTrackBar.TabIndex = 10;
            this.inclineYArgTrackBar.Value = 1;
            this.inclineYArgTrackBar.Scroll += new System.EventHandler(this.inclineYArgTrackBar_Scroll);
            // 
            // generateInclineEffect
            // 
            this.generateInclineEffect.Location = new System.Drawing.Point(182, 80);
            this.generateInclineEffect.Name = "generateInclineEffect";
            this.generateInclineEffect.Size = new System.Drawing.Size(160, 28);
            this.generateInclineEffect.TabIndex = 3;
            this.generateInclineEffect.Text = "Generate";
            this.generateInclineEffect.UseVisualStyleBackColor = true;
            this.generateInclineEffect.Click += new System.EventHandler(this.generateInclineEffect_Click);
            // 
            // resetInclineData
            // 
            this.resetInclineData.Location = new System.Drawing.Point(6, 80);
            this.resetInclineData.Name = "resetInclineData";
            this.resetInclineData.Size = new System.Drawing.Size(160, 28);
            this.resetInclineData.TabIndex = 18;
            this.resetInclineData.Text = "Reset";
            this.resetInclineData.UseVisualStyleBackColor = true;
            this.resetInclineData.Click += new System.EventHandler(this.resetInclineData_Click);
            // 
            // inclineYArgValue
            // 
            this.inclineYArgValue.Location = new System.Drawing.Point(200, 51);
            this.inclineYArgValue.Name = "inclineYArgValue";
            this.inclineYArgValue.Size = new System.Drawing.Size(142, 23);
            this.inclineYArgValue.TabIndex = 19;
            this.inclineYArgValue.Text = "1";
            this.inclineYArgValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inclineEffectGroup
            // 
            this.inclineEffectGroup.Controls.Add(this.inclineXArgValue);
            this.inclineEffectGroup.Controls.Add(this.inclineXArgTrackBar);
            this.inclineEffectGroup.Controls.Add(this.label3);
            this.inclineEffectGroup.Controls.Add(this.inclineYArgValue);
            this.inclineEffectGroup.Controls.Add(this.resetInclineData);
            this.inclineEffectGroup.Controls.Add(this.generateInclineEffect);
            this.inclineEffectGroup.Controls.Add(this.inclineYArgTrackBar);
            this.inclineEffectGroup.Controls.Add(this.label4);
            this.inclineEffectGroup.Location = new System.Drawing.Point(467, 280);
            this.inclineEffectGroup.Name = "inclineEffectGroup";
            this.inclineEffectGroup.Size = new System.Drawing.Size(359, 114);
            this.inclineEffectGroup.TabIndex = 22;
            this.inclineEffectGroup.TabStop = false;
            this.inclineEffectGroup.Text = "Incline";
            // 
            // inclineXArgValue
            // 
            this.inclineXArgValue.Location = new System.Drawing.Point(33, 51);
            this.inclineXArgValue.Name = "inclineXArgValue";
            this.inclineXArgValue.Size = new System.Drawing.Size(142, 23);
            this.inclineXArgValue.TabIndex = 22;
            this.inclineXArgValue.Text = "1";
            this.inclineXArgValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inclineXArgTrackBar
            // 
            this.inclineXArgTrackBar.AccessibleDescription = "Red Chanel";
            this.inclineXArgTrackBar.AccessibleName = "Red";
            this.inclineXArgTrackBar.Location = new System.Drawing.Point(33, 18);
            this.inclineXArgTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.inclineXArgTrackBar.Minimum = 1;
            this.inclineXArgTrackBar.Name = "inclineXArgTrackBar";
            this.inclineXArgTrackBar.Size = new System.Drawing.Size(142, 56);
            this.inclineXArgTrackBar.TabIndex = 2;
            this.inclineXArgTrackBar.Value = 1;
            this.inclineXArgTrackBar.Scroll += new System.EventHandler(this.inclineXArgTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FourthLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 406);
            this.Controls.Add(this.inclineEffectGroup);
            this.Controls.Add(this.mirrorGroup);
            this.Controls.Add(this.invertButton);
            this.Controls.Add(this.rotateGroupBox);
            this.Controls.Add(this.generatedPicture);
            this.Controls.Add(this.originalPicture);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.backButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(863, 900);
            this.Name = "FourthLab";
            this.Text = "Fourth Lab";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedPicture)).EndInit();
            this.rotateGroupBox.ResumeLayout(false);
            this.rotateGroupBox.PerformLayout();
            this.mirrorGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inclineYArgTrackBar)).EndInit();
            this.inclineEffectGroup.ResumeLayout(false);
            this.inclineEffectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclineXArgTrackBar)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label inclineXArgValue;
        private System.Windows.Forms.TrackBar inclineXArgTrackBar;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox originalPicture;
        private System.Windows.Forms.PictureBox generatedPicture;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rotateTextBox;
        private System.Windows.Forms.GroupBox rotateGroupBox;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Button mirrorVerticalButton;
        private System.Windows.Forms.Button mirrorHorizontalButton;
        private System.Windows.Forms.GroupBox mirrorGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar inclineYArgTrackBar;
        private System.Windows.Forms.Button generateInclineEffect;
        private System.Windows.Forms.Button resetInclineData;
        private System.Windows.Forms.Label inclineYArgValue;
        private System.Windows.Forms.GroupBox inclineEffectGroup;

        private System.Windows.Forms.ColorDialog linesColorModal;

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        #endregion
    }
}