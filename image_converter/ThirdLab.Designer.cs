using System.ComponentModel;

namespace image_converter
{
    partial class ThirdLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.greenTrackBarValue = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.labelBtrack = new System.Windows.Forms.Label();
            this.blueTrackBarValue = new System.Windows.Forms.Label();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.resetWeightsButton = new System.Windows.Forms.Button();
            this.greyFilterBox = new System.Windows.Forms.GroupBox();
            this.redTrackBarValue = new System.Windows.Forms.Label();
            this.invertButton = new System.Windows.Forms.Button();
            this.linesGroup = new System.Windows.Forms.GroupBox();
            this.verticalRadioButton = new System.Windows.Forms.RadioButton();
            this.horizontalRadioButton = new System.Windows.Forms.RadioButton();
            this.linesNumberText = new System.Windows.Forms.Label();
            this.resetLinesValue = new System.Windows.Forms.Button();
            this.generateLinesButton = new System.Windows.Forms.Button();
            this.linesNumberTrackBar = new System.Windows.Forms.TrackBar();
            this.LinesText = new System.Windows.Forms.Label();
            this.linesColorModal = new System.Windows.Forms.ColorDialog();
            this.gassEffectGroup = new System.Windows.Forms.GroupBox();
            this.secondGlassEffectRadioButton = new System.Windows.Forms.RadioButton();
            this.glassStrengthText = new System.Windows.Forms.Label();
            this.resetGlassData = new System.Windows.Forms.Button();
            this.generateGlassEffect = new System.Windows.Forms.Button();
            this.glassStrengthTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.wavesGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.yCoordinateV4Text = new System.Windows.Forms.Label();
            this.yCoordinateV4TrackBar = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.xCoordinateV2Text = new System.Windows.Forms.Label();
            this.xCoordinateV2TrackBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.xCoordinateV1Text = new System.Windows.Forms.Label();
            this.xCoordinateV1TrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.secondWavesEffectRadioButton = new System.Windows.Forms.RadioButton();
            this.yCoordinateV3Text = new System.Windows.Forms.Label();
            this.resetWavesEffectButton = new System.Windows.Forms.Button();
            this.generateWavesEffect = new System.Windows.Forms.Button();
            this.yCoordinateV3TrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            this.greyFilterBox.SuspendLayout();
            this.linesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumberTrackBar)).BeginInit();
            this.gassEffectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glassStrengthTrackBar)).BeginInit();
            this.wavesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateV4TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateV2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateV1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateV3TrackBar)).BeginInit();
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
            this.convertButton.Location = new System.Drawing.Point(211, 80);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(199, 28);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Generate";
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
            this.saveFileDialog.FileName = "generated_image";
            this.saveFileDialog.Filter = "JPEG|*.jpg|JPG|*.jpg;*.jpeg|BMP|*.bmp ";
            // 
            // redTrackBar
            // 
            this.redTrackBar.AccessibleDescription = "Red Chanel";
            this.redTrackBar.AccessibleName = "Red";
            this.redTrackBar.Location = new System.Drawing.Point(42, 18);
            this.redTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(240, 56);
            this.redTrackBar.TabIndex = 10;
            this.redTrackBar.TickFrequency = 10;
            this.redTrackBar.Value = 77;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(281, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "G";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // greenTrackBarValue
            // 
            this.greenTrackBarValue.Location = new System.Drawing.Point(301, 54);
            this.greenTrackBarValue.Name = "greenTrackBarValue";
            this.greenTrackBarValue.Size = new System.Drawing.Size(240, 23);
            this.greenTrackBarValue.TabIndex = 14;
            this.greenTrackBarValue.Text = "150";
            this.greenTrackBarValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.AccessibleDescription = "Red Chanel";
            this.greenTrackBar.AccessibleName = "Red";
            this.greenTrackBar.Location = new System.Drawing.Point(301, 21);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(240, 56);
            this.greenTrackBar.TabIndex = 13;
            this.greenTrackBar.TickFrequency = 10;
            this.greenTrackBar.Value = 77;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // labelBtrack
            // 
            this.labelBtrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBtrack.ForeColor = System.Drawing.Color.Blue;
            this.labelBtrack.Location = new System.Drawing.Point(542, 21);
            this.labelBtrack.Name = "labelBtrack";
            this.labelBtrack.Size = new System.Drawing.Size(28, 28);
            this.labelBtrack.TabIndex = 15;
            this.labelBtrack.Text = "B";
            this.labelBtrack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // blueTrackBarValue
            // 
            this.blueTrackBarValue.Location = new System.Drawing.Point(558, 54);
            this.blueTrackBarValue.Name = "blueTrackBarValue";
            this.blueTrackBarValue.Size = new System.Drawing.Size(240, 23);
            this.blueTrackBarValue.TabIndex = 17;
            this.blueTrackBarValue.Text = "29";
            this.blueTrackBarValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.AccessibleDescription = "Red Chanel";
            this.blueTrackBar.AccessibleName = "Red";
            this.blueTrackBar.Location = new System.Drawing.Point(558, 21);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(240, 56);
            this.blueTrackBar.TabIndex = 16;
            this.blueTrackBar.TickFrequency = 10;
            this.blueTrackBar.Value = 29;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // resetWeightsButton
            // 
            this.resetWeightsButton.Location = new System.Drawing.Point(6, 80);
            this.resetWeightsButton.Name = "resetWeightsButton";
            this.resetWeightsButton.Size = new System.Drawing.Size(199, 28);
            this.resetWeightsButton.TabIndex = 18;
            this.resetWeightsButton.Text = "Reset";
            this.resetWeightsButton.UseVisualStyleBackColor = true;
            this.resetWeightsButton.Click += new System.EventHandler(this.resetWeightsButton_Click);
            // 
            // greyFilterBox
            // 
            this.greyFilterBox.Controls.Add(this.redTrackBarValue);
            this.greyFilterBox.Controls.Add(this.resetWeightsButton);
            this.greyFilterBox.Controls.Add(this.blueTrackBarValue);
            this.greyFilterBox.Controls.Add(this.labelBtrack);
            this.greyFilterBox.Controls.Add(this.blueTrackBar);
            this.greyFilterBox.Controls.Add(this.convertButton);
            this.greyFilterBox.Controls.Add(this.redTrackBar);
            this.greyFilterBox.Controls.Add(this.greenTrackBarValue);
            this.greyFilterBox.Controls.Add(this.greenTrackBar);
            this.greyFilterBox.Controls.Add(this.label2);
            this.greyFilterBox.Controls.Add(this.label1);
            this.greyFilterBox.Location = new System.Drawing.Point(12, 280);
            this.greyFilterBox.Name = "greyFilterBox";
            this.greyFilterBox.Size = new System.Drawing.Size(814, 117);
            this.greyFilterBox.TabIndex = 19;
            this.greyFilterBox.TabStop = false;
            this.greyFilterBox.Text = "Black and White filter";
            // 
            // redTrackBarValue
            // 
            this.redTrackBarValue.Location = new System.Drawing.Point(42, 54);
            this.redTrackBarValue.Name = "redTrackBarValue";
            this.redTrackBarValue.Size = new System.Drawing.Size(240, 23);
            this.redTrackBarValue.TabIndex = 19;
            this.redTrackBarValue.Text = "77";
            this.redTrackBarValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // linesGroup
            // 
            this.linesGroup.Controls.Add(this.verticalRadioButton);
            this.linesGroup.Controls.Add(this.horizontalRadioButton);
            this.linesGroup.Controls.Add(this.linesNumberText);
            this.linesGroup.Controls.Add(this.resetLinesValue);
            this.linesGroup.Controls.Add(this.generateLinesButton);
            this.linesGroup.Controls.Add(this.linesNumberTrackBar);
            this.linesGroup.Controls.Add(this.LinesText);
            this.linesGroup.Location = new System.Drawing.Point(12, 403);
            this.linesGroup.Name = "linesGroup";
            this.linesGroup.Size = new System.Drawing.Size(424, 117);
            this.linesGroup.TabIndex = 20;
            this.linesGroup.TabStop = false;
            this.linesGroup.Text = "Add lines to image";
            // 
            // verticalRadioButton
            // 
            this.verticalRadioButton.Location = new System.Drawing.Point(301, 47);
            this.verticalRadioButton.Name = "verticalRadioButton";
            this.verticalRadioButton.Size = new System.Drawing.Size(109, 23);
            this.verticalRadioButton.TabIndex = 21;
            this.verticalRadioButton.Text = "Vertical";
            this.verticalRadioButton.UseVisualStyleBackColor = true;
            // 
            // horizontalRadioButton
            // 
            this.horizontalRadioButton.Checked = true;
            this.horizontalRadioButton.Location = new System.Drawing.Point(301, 18);
            this.horizontalRadioButton.Name = "horizontalRadioButton";
            this.horizontalRadioButton.Size = new System.Drawing.Size(109, 23);
            this.horizontalRadioButton.TabIndex = 20;
            this.horizontalRadioButton.TabStop = true;
            this.horizontalRadioButton.Text = "Horizontal";
            this.horizontalRadioButton.UseVisualStyleBackColor = true;
            // 
            // linesNumberText
            // 
            this.linesNumberText.Location = new System.Drawing.Point(56, 54);
            this.linesNumberText.Name = "linesNumberText";
            this.linesNumberText.Size = new System.Drawing.Size(214, 23);
            this.linesNumberText.TabIndex = 19;
            this.linesNumberText.Text = "3";
            this.linesNumberText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resetLinesValue
            // 
            this.resetLinesValue.Location = new System.Drawing.Point(6, 80);
            this.resetLinesValue.Name = "resetLinesValue";
            this.resetLinesValue.Size = new System.Drawing.Size(199, 28);
            this.resetLinesValue.TabIndex = 18;
            this.resetLinesValue.Text = "Reset";
            this.resetLinesValue.UseVisualStyleBackColor = true;
            this.resetLinesValue.Click += new System.EventHandler(this.resetLinesValue_Click);
            // 
            // generateLinesButton
            // 
            this.generateLinesButton.Location = new System.Drawing.Point(211, 80);
            this.generateLinesButton.Name = "generateLinesButton";
            this.generateLinesButton.Size = new System.Drawing.Size(199, 28);
            this.generateLinesButton.TabIndex = 3;
            this.generateLinesButton.Text = "Generate";
            this.generateLinesButton.UseVisualStyleBackColor = true;
            this.generateLinesButton.Click += new System.EventHandler(this.generateLinesButton_Click);
            // 
            // linesNumberTrackBar
            // 
            this.linesNumberTrackBar.AccessibleDescription = "Red Chanel";
            this.linesNumberTrackBar.AccessibleName = "Red";
            this.linesNumberTrackBar.Location = new System.Drawing.Point(56, 18);
            this.linesNumberTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.linesNumberTrackBar.Maximum = 50;
            this.linesNumberTrackBar.Name = "linesNumberTrackBar";
            this.linesNumberTrackBar.Size = new System.Drawing.Size(214, 56);
            this.linesNumberTrackBar.TabIndex = 10;
            this.linesNumberTrackBar.TickFrequency = 5;
            this.linesNumberTrackBar.Value = 3;
            this.linesNumberTrackBar.Scroll += new System.EventHandler(this.linesNumberTrackBar_Scroll);
            // 
            // LinesText
            // 
            this.LinesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinesText.ForeColor = System.Drawing.Color.Black;
            this.LinesText.Location = new System.Drawing.Point(6, 21);
            this.LinesText.Name = "LinesText";
            this.LinesText.Size = new System.Drawing.Size(47, 28);
            this.LinesText.TabIndex = 12;
            this.LinesText.Text = "Lines";
            this.LinesText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gassEffectGroup
            // 
            this.gassEffectGroup.Controls.Add(this.secondGlassEffectRadioButton);
            this.gassEffectGroup.Controls.Add(this.glassStrengthText);
            this.gassEffectGroup.Controls.Add(this.resetGlassData);
            this.gassEffectGroup.Controls.Add(this.generateGlassEffect);
            this.gassEffectGroup.Controls.Add(this.glassStrengthTrackBar);
            this.gassEffectGroup.Controls.Add(this.label4);
            this.gassEffectGroup.Location = new System.Drawing.Point(442, 403);
            this.gassEffectGroup.Name = "gassEffectGroup";
            this.gassEffectGroup.Size = new System.Drawing.Size(384, 117);
            this.gassEffectGroup.TabIndex = 22;
            this.gassEffectGroup.TabStop = false;
            this.gassEffectGroup.Text = "Fish Eye Effect";
            // 
            // secondGlassEffectRadioButton
            // 
            this.secondGlassEffectRadioButton.Location = new System.Drawing.Point(313, 36);
            this.secondGlassEffectRadioButton.Name = "secondGlassEffectRadioButton";
            this.secondGlassEffectRadioButton.Size = new System.Drawing.Size(55, 24);
            this.secondGlassEffectRadioButton.TabIndex = 20;
            this.secondGlassEffectRadioButton.TabStop = true;
            this.secondGlassEffectRadioButton.Text = "V2";
            this.secondGlassEffectRadioButton.UseVisualStyleBackColor = true;
            // 
            // glassStrengthText
            // 
            this.glassStrengthText.Location = new System.Drawing.Point(37, 54);
            this.glassStrengthText.Name = "glassStrengthText";
            this.glassStrengthText.Size = new System.Drawing.Size(273, 23);
            this.glassStrengthText.TabIndex = 19;
            this.glassStrengthText.Text = "12";
            this.glassStrengthText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resetGlassData
            // 
            this.resetGlassData.Location = new System.Drawing.Point(6, 80);
            this.resetGlassData.Name = "resetGlassData";
            this.resetGlassData.Size = new System.Drawing.Size(160, 28);
            this.resetGlassData.TabIndex = 18;
            this.resetGlassData.Text = "Reset";
            this.resetGlassData.UseVisualStyleBackColor = true;
            this.resetGlassData.Click += new System.EventHandler(this.resetGlassData_Click);
            // 
            // generateGlassEffect
            // 
            this.generateGlassEffect.Location = new System.Drawing.Point(211, 80);
            this.generateGlassEffect.Name = "generateGlassEffect";
            this.generateGlassEffect.Size = new System.Drawing.Size(160, 28);
            this.generateGlassEffect.TabIndex = 3;
            this.generateGlassEffect.Text = "Generate";
            this.generateGlassEffect.UseVisualStyleBackColor = true;
            this.generateGlassEffect.Click += new System.EventHandler(this.generateGlassEffect_Click);
            // 
            // glassStrengthTrackBar
            // 
            this.glassStrengthTrackBar.AccessibleDescription = "Red Chanel";
            this.glassStrengthTrackBar.AccessibleName = "Red";
            this.glassStrengthTrackBar.Location = new System.Drawing.Point(37, 18);
            this.glassStrengthTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.glassStrengthTrackBar.Maximum = 40;
            this.glassStrengthTrackBar.Name = "glassStrengthTrackBar";
            this.glassStrengthTrackBar.Size = new System.Drawing.Size(273, 56);
            this.glassStrengthTrackBar.SmallChange = 2;
            this.glassStrengthTrackBar.TabIndex = 10;
            this.glassStrengthTrackBar.TickFrequency = 2;
            this.glassStrengthTrackBar.Value = 12;
            this.glassStrengthTrackBar.Scroll += new System.EventHandler(this.glassStrengthTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "V";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wavesGroupBox
            // 
            this.wavesGroupBox.Controls.Add(this.label13);
            this.wavesGroupBox.Controls.Add(this.label12);
            this.wavesGroupBox.Controls.Add(this.yCoordinateV4Text);
            this.wavesGroupBox.Controls.Add(this.yCoordinateV4TrackBar);
            this.wavesGroupBox.Controls.Add(this.label11);
            this.wavesGroupBox.Controls.Add(this.xCoordinateV2Text);
            this.wavesGroupBox.Controls.Add(this.xCoordinateV2TrackBar);
            this.wavesGroupBox.Controls.Add(this.label9);
            this.wavesGroupBox.Controls.Add(this.xCoordinateV1Text);
            this.wavesGroupBox.Controls.Add(this.xCoordinateV1TrackBar);
            this.wavesGroupBox.Controls.Add(this.label7);
            this.wavesGroupBox.Controls.Add(this.secondWavesEffectRadioButton);
            this.wavesGroupBox.Controls.Add(this.yCoordinateV3Text);
            this.wavesGroupBox.Controls.Add(this.resetWavesEffectButton);
            this.wavesGroupBox.Controls.Add(this.generateWavesEffect);
            this.wavesGroupBox.Controls.Add(this.yCoordinateV3TrackBar);
            this.wavesGroupBox.Controls.Add(this.label5);
            this.wavesGroupBox.Location = new System.Drawing.Point(12, 526);
            this.wavesGroupBox.Name = "wavesGroupBox";
            this.wavesGroupBox.Size = new System.Drawing.Size(814, 148);
            this.wavesGroupBox.TabIndex = 23;
            this.wavesGroupBox.TabStop = false;
            this.wavesGroupBox.Text = "Waves Effect";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(492, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "Y cords";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(178, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "X cords";
            // 
            // yCoordinateV4Text
            // 
            this.yCoordinateV4Text.Location = new System.Drawing.Point(538, 110);
            this.yCoordinateV4Text.Name = "yCoordinateV4Text";
            this.yCoordinateV4Text.Size = new System.Drawing.Size(273, 23);
            this.yCoordinateV4Text.TabIndex = 29;
            this.yCoordinateV4Text.Text = "50";
            this.yCoordinateV4Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yCoordinateV4TrackBar
            // 
            this.yCoordinateV4TrackBar.AccessibleDescription = "Red Chanel";
            this.yCoordinateV4TrackBar.AccessibleName = "Red";
            this.yCoordinateV4TrackBar.Location = new System.Drawing.Point(538, 74);
            this.yCoordinateV4TrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.yCoordinateV4TrackBar.Maximum = 100;
            this.yCoordinateV4TrackBar.Name = "yCoordinateV4TrackBar";
            this.yCoordinateV4TrackBar.Size = new System.Drawing.Size(273, 56);
            this.yCoordinateV4TrackBar.SmallChange = 2;
            this.yCoordinateV4TrackBar.TabIndex = 27;
            this.yCoordinateV4TrackBar.TickFrequency = 5;
            this.yCoordinateV4TrackBar.Value = 50;
            this.yCoordinateV4TrackBar.Scroll += new System.EventHandler(this.yCoordinateV4TrackBar_Scroll);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(507, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 28);
            this.label11.TabIndex = 28;
            this.label11.Text = "V4";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xCoordinateV2Text
            // 
            this.xCoordinateV2Text.Location = new System.Drawing.Point(231, 110);
            this.xCoordinateV2Text.Name = "xCoordinateV2Text";
            this.xCoordinateV2Text.Size = new System.Drawing.Size(273, 23);
            this.xCoordinateV2Text.TabIndex = 26;
            this.xCoordinateV2Text.Text = "50";
            this.xCoordinateV2Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xCoordinateV2TrackBar
            // 
            this.xCoordinateV2TrackBar.AccessibleDescription = "Red Chanel";
            this.xCoordinateV2TrackBar.AccessibleName = "Red";
            this.xCoordinateV2TrackBar.Location = new System.Drawing.Point(231, 74);
            this.xCoordinateV2TrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.xCoordinateV2TrackBar.Maximum = 100;
            this.xCoordinateV2TrackBar.Name = "xCoordinateV2TrackBar";
            this.xCoordinateV2TrackBar.Size = new System.Drawing.Size(273, 56);
            this.xCoordinateV2TrackBar.SmallChange = 2;
            this.xCoordinateV2TrackBar.TabIndex = 24;
            this.xCoordinateV2TrackBar.TickFrequency = 5;
            this.xCoordinateV2TrackBar.Value = 50;
            this.xCoordinateV2TrackBar.Scroll += new System.EventHandler(this.xCoordinateV2TrackBar_Scroll);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(200, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "V2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xCoordinateV1Text
            // 
            this.xCoordinateV1Text.Location = new System.Drawing.Point(231, 54);
            this.xCoordinateV1Text.Name = "xCoordinateV1Text";
            this.xCoordinateV1Text.Size = new System.Drawing.Size(273, 23);
            this.xCoordinateV1Text.TabIndex = 23;
            this.xCoordinateV1Text.Text = "50";
            this.xCoordinateV1Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xCoordinateV1TrackBar
            // 
            this.xCoordinateV1TrackBar.AccessibleDescription = "Red Chanel";
            this.xCoordinateV1TrackBar.AccessibleName = "Red";
            this.xCoordinateV1TrackBar.Location = new System.Drawing.Point(231, 18);
            this.xCoordinateV1TrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.xCoordinateV1TrackBar.Maximum = 100;
            this.xCoordinateV1TrackBar.Name = "xCoordinateV1TrackBar";
            this.xCoordinateV1TrackBar.Size = new System.Drawing.Size(273, 56);
            this.xCoordinateV1TrackBar.SmallChange = 2;
            this.xCoordinateV1TrackBar.TabIndex = 21;
            this.xCoordinateV1TrackBar.TickFrequency = 5;
            this.xCoordinateV1TrackBar.Value = 50;
            this.xCoordinateV1TrackBar.Scroll += new System.EventHandler(this.xCoordinateV1TrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(200, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "V1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondWavesEffectRadioButton
            // 
            this.secondWavesEffectRadioButton.Location = new System.Drawing.Point(56, 25);
            this.secondWavesEffectRadioButton.Name = "secondWavesEffectRadioButton";
            this.secondWavesEffectRadioButton.Size = new System.Drawing.Size(55, 24);
            this.secondWavesEffectRadioButton.TabIndex = 20;
            this.secondWavesEffectRadioButton.TabStop = true;
            this.secondWavesEffectRadioButton.Text = "V2";
            this.secondWavesEffectRadioButton.UseVisualStyleBackColor = true;
            // 
            // yCoordinateV3Text
            // 
            this.yCoordinateV3Text.Location = new System.Drawing.Point(538, 54);
            this.yCoordinateV3Text.Name = "yCoordinateV3Text";
            this.yCoordinateV3Text.Size = new System.Drawing.Size(273, 23);
            this.yCoordinateV3Text.TabIndex = 19;
            this.yCoordinateV3Text.Text = "50";
            this.yCoordinateV3Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resetWavesEffectButton
            // 
            this.resetWavesEffectButton.Location = new System.Drawing.Point(6, 98);
            this.resetWavesEffectButton.Name = "resetWavesEffectButton";
            this.resetWavesEffectButton.Size = new System.Drawing.Size(160, 28);
            this.resetWavesEffectButton.TabIndex = 18;
            this.resetWavesEffectButton.Text = "Reset";
            this.resetWavesEffectButton.UseVisualStyleBackColor = true;
            this.resetWavesEffectButton.Click += new System.EventHandler(this.resetWavesEffectButton_Click);
            // 
            // generateWavesEffect
            // 
            this.generateWavesEffect.Location = new System.Drawing.Point(6, 64);
            this.generateWavesEffect.Name = "generateWavesEffect";
            this.generateWavesEffect.Size = new System.Drawing.Size(160, 28);
            this.generateWavesEffect.TabIndex = 3;
            this.generateWavesEffect.Text = "Generate";
            this.generateWavesEffect.UseVisualStyleBackColor = true;
            this.generateWavesEffect.Click += new System.EventHandler(this.generateWavesEffect_Click);
            // 
            // yCoordinateV3TrackBar
            // 
            this.yCoordinateV3TrackBar.AccessibleDescription = "Red Chanel";
            this.yCoordinateV3TrackBar.AccessibleName = "Red";
            this.yCoordinateV3TrackBar.Location = new System.Drawing.Point(538, 18);
            this.yCoordinateV3TrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.yCoordinateV3TrackBar.Maximum = 100;
            this.yCoordinateV3TrackBar.Name = "yCoordinateV3TrackBar";
            this.yCoordinateV3TrackBar.Size = new System.Drawing.Size(273, 56);
            this.yCoordinateV3TrackBar.SmallChange = 2;
            this.yCoordinateV3TrackBar.TabIndex = 10;
            this.yCoordinateV3TrackBar.TickFrequency = 5;
            this.yCoordinateV3TrackBar.Value = 50;
            this.yCoordinateV3TrackBar.Scroll += new System.EventHandler(this.yCoordinateV3TrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(507, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "V3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 0;
            // 
            // ThirdLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 708);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.wavesGroupBox);
            this.Controls.Add(this.gassEffectGroup);
            this.Controls.Add(this.linesGroup);
            this.Controls.Add(this.invertButton);
            this.Controls.Add(this.greyFilterBox);
            this.Controls.Add(this.generatedPicture);
            this.Controls.Add(this.originalPicture);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.backButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(863, 900);
            this.Name = "ThirdLab";
            this.Text = "Third Lab";
            ((System.ComponentModel.ISupportInitialize)(this.originalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.greyFilterBox.ResumeLayout(false);
            this.greyFilterBox.PerformLayout();
            this.linesGroup.ResumeLayout(false);
            this.linesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumberTrackBar)).EndInit();
            this.gassEffectGroup.ResumeLayout(false);
            this.gassEffectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glassStrengthTrackBar)).EndInit();
            this.wavesGroupBox.ResumeLayout(false);
            this.wavesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateV4TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateV2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateV1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateV3TrackBar)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ProgressBar progressBar;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label xCoordinateV1Text;
        private System.Windows.Forms.TrackBar xCoordinateV1TrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label xCoordinateV2Text;
        private System.Windows.Forms.TrackBar xCoordinateV2TrackBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label yCoordinateV4Text;
        private System.Windows.Forms.TrackBar yCoordinateV4TrackBar;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.GroupBox wavesGroupBox;
        private System.Windows.Forms.RadioButton secondWavesEffectRadioButton;
        private System.Windows.Forms.Label yCoordinateV3Text;
        private System.Windows.Forms.Button resetWavesEffectButton;
        private System.Windows.Forms.Button generateWavesEffect;
        private System.Windows.Forms.TrackBar yCoordinateV3TrackBar;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.RadioButton secondGlassEffectRadioButton;

        private System.Windows.Forms.GroupBox gassEffectGroup;
        private System.Windows.Forms.Label glassStrengthText;
        private System.Windows.Forms.Button resetGlassData;
        private System.Windows.Forms.Button generateGlassEffect;
        private System.Windows.Forms.TrackBar glassStrengthTrackBar;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.RadioButton verticalRadioButton;

        private System.Windows.Forms.RadioButton horizontalRadioButton;

        private System.Windows.Forms.ColorDialog linesColorModal;

        private System.Windows.Forms.GroupBox linesGroup;
        private System.Windows.Forms.Label linesNumberText;
        private System.Windows.Forms.Button resetLinesValue;
        private System.Windows.Forms.Button generateLinesButton;
        private System.Windows.Forms.TrackBar linesNumberTrackBar;
        private System.Windows.Forms.Label LinesText;

        private System.Windows.Forms.Button invertButton;

        private System.Windows.Forms.Label redTrackBarValue;

        private System.Windows.Forms.GroupBox greyFilterBox;

        private System.Windows.Forms.Button resetWeightsButton;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.Label labelBtrack;
        private System.Windows.Forms.Label blueTrackBarValue;
        private System.Windows.Forms.TrackBar blueTrackBar;

        private System.Windows.Forms.Label label1;

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