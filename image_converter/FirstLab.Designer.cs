using System.ComponentModel;

namespace image_converter
{
    partial class FirstLab
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.redPictureBox = new System.Windows.Forms.PictureBox();
            this.greenPictureBox = new System.Windows.Forms.PictureBox();
            this.bluePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RGBTextBox = new System.Windows.Forms.TextBox();
            this.HexTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.disperseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 14);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(199, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back to main menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.Location = new System.Drawing.Point(13, 442);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(136, 33);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPictureBox.Location = new System.Drawing.Point(24, 102);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(361, 212);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 3;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.originalPictureBox_MouseClick);
            // 
            // redPictureBox
            // 
            this.redPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.redPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redPictureBox.Location = new System.Drawing.Point(504, 14);
            this.redPictureBox.Name = "redPictureBox";
            this.redPictureBox.Size = new System.Drawing.Size(284, 145);
            this.redPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPictureBox.TabIndex = 4;
            this.redPictureBox.TabStop = false;
            // 
            // greenPictureBox
            // 
            this.greenPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.greenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenPictureBox.Location = new System.Drawing.Point(504, 169);
            this.greenPictureBox.Name = "greenPictureBox";
            this.greenPictureBox.Size = new System.Drawing.Size(284, 145);
            this.greenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenPictureBox.TabIndex = 5;
            this.greenPictureBox.TabStop = false;
            // 
            // bluePictureBox
            // 
            this.bluePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bluePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bluePictureBox.Location = new System.Drawing.Point(504, 320);
            this.bluePictureBox.Name = "bluePictureBox";
            this.bluePictureBox.Size = new System.Drawing.Size(284, 145);
            this.bluePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePictureBox.TabIndex = 6;
            this.bluePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(431, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Red:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(412, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Green:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(412, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Blue:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "RGB: ";
            // 
            // RGBTextBox
            // 
            this.RGBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGBTextBox.Location = new System.Drawing.Point(75, 331);
            this.RGBTextBox.Name = "RGBTextBox";
            this.RGBTextBox.ReadOnly = true;
            this.RGBTextBox.Size = new System.Drawing.Size(310, 26);
            this.RGBTextBox.TabIndex = 12;
            // 
            // HexTextBox
            // 
            this.HexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HexTextBox.Location = new System.Drawing.Point(75, 363);
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.ReadOnly = true;
            this.HexTextBox.Size = new System.Drawing.Size(310, 26);
            this.HexTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "HEX: ";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberTextBox.Location = new System.Drawing.Point(75, 395);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(310, 26);
            this.NumberTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "NUM: ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG|*.jpg|JPG|*.jpg;*.jpeg|BMP|*.bmp ";
            // 
            // disperseButton
            // 
            this.disperseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disperseButton.Location = new System.Drawing.Point(164, 442);
            this.disperseButton.Name = "disperseButton";
            this.disperseButton.Size = new System.Drawing.Size(136, 33);
            this.disperseButton.TabIndex = 18;
            this.disperseButton.Text = "Disperse";
            this.disperseButton.UseVisualStyleBackColor = true;
            this.disperseButton.Click += new System.EventHandler(this.disperseButton_Click);
            // 
            // FirstLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.disperseButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HexTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RGBTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bluePictureBox);
            this.Controls.Add(this.greenPictureBox);
            this.Controls.Add(this.redPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.backButton);
            this.Name = "FirstLab";
            this.Text = "FirstLab";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button disperseButton;

        private System.Windows.Forms.PictureBox bluePictureBox;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.PictureBox greenPictureBox;

        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox RGBTextBox;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox HexTextBox;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox redPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button openFileButton;

        private System.Windows.Forms.Button backButton;

        #endregion
    }
}