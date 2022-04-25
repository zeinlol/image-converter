using System.ComponentModel;

namespace image_converter
{
    partial class MainForm
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
            this.lab1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab2Button = new System.Windows.Forms.Button();
            this.Lab3Button = new System.Windows.Forms.Button();
            this.Lab4Button = new System.Windows.Forms.Button();
            this.lab5Button = new System.Windows.Forms.Button();
            this.lab6Sixth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1Button
            // 
            this.lab1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab1Button.Location = new System.Drawing.Point(57, 118);
            this.lab1Button.Name = "lab1Button";
            this.lab1Button.Size = new System.Drawing.Size(190, 42);
            this.lab1Button.TabIndex = 0;
            this.lab1Button.Text = "First lab";
            this.lab1Button.UseVisualStyleBackColor = true;
            this.lab1Button.Click += new System.EventHandler(this.lab1Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose task";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab2Button
            // 
            this.lab2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab2Button.Location = new System.Drawing.Point(57, 166);
            this.lab2Button.Name = "lab2Button";
            this.lab2Button.Size = new System.Drawing.Size(190, 42);
            this.lab2Button.TabIndex = 3;
            this.lab2Button.Text = "Second lab";
            this.lab2Button.UseVisualStyleBackColor = true;
            this.lab2Button.Click += new System.EventHandler(this.lab2Button_Click);
            // 
            // Lab3Button
            // 
            this.Lab3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lab3Button.Location = new System.Drawing.Point(57, 214);
            this.Lab3Button.Name = "Lab3Button";
            this.Lab3Button.Size = new System.Drawing.Size(190, 42);
            this.Lab3Button.TabIndex = 4;
            this.Lab3Button.Text = "Third lab";
            this.Lab3Button.UseVisualStyleBackColor = true;
            this.Lab3Button.Click += new System.EventHandler(this.lab3Button_Click);
            // 
            // Lab4Button
            // 
            this.Lab4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lab4Button.Location = new System.Drawing.Point(57, 262);
            this.Lab4Button.Name = "Lab4Button";
            this.Lab4Button.Size = new System.Drawing.Size(190, 42);
            this.Lab4Button.TabIndex = 5;
            this.Lab4Button.Text = "Fourth Lab";
            this.Lab4Button.UseVisualStyleBackColor = true;
            this.Lab4Button.Click += new System.EventHandler(this.Lab4Button_Click);
            // 
            // lab5Button
            // 
            this.lab5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab5Button.Location = new System.Drawing.Point(57, 310);
            this.lab5Button.Name = "lab5Button";
            this.lab5Button.Size = new System.Drawing.Size(190, 42);
            this.lab5Button.TabIndex = 6;
            this.lab5Button.Text = "Fifth Lab";
            this.lab5Button.UseVisualStyleBackColor = true;
            this.lab5Button.Click += new System.EventHandler(this.lab5Button_Click);
            // 
            // lab6Sixth
            // 
            this.lab6Sixth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab6Sixth.Location = new System.Drawing.Point(57, 358);
            this.lab6Sixth.Name = "lab6Sixth";
            this.lab6Sixth.Size = new System.Drawing.Size(190, 42);
            this.lab6Sixth.TabIndex = 7;
            this.lab6Sixth.Text = "Sixth Lab";
            this.lab6Sixth.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 413);
            this.Controls.Add(this.lab6Sixth);
            this.Controls.Add(this.lab5Button);
            this.Controls.Add(this.Lab4Button);
            this.Controls.Add(this.Lab3Button);
            this.Controls.Add(this.lab2Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1Button);
            this.MaximumSize = new System.Drawing.Size(330, 460);
            this.Name = "MainForm";
            this.Text = "Image Converter";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button lab5Button;
        private System.Windows.Forms.Button lab6Sixth;

        private System.Windows.Forms.Button Lab4Button;

        private System.Windows.Forms.Button Lab3Button;

        private System.Windows.Forms.Button lab2Button;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button lab1Button;

        #endregion
    }
}