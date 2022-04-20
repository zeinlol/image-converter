using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace image_converter
{
    public partial class ThirdLab : Form
    {
        private const int BlueChanelArgDefault = 29;
        private const int GreenChanelArgDefault = 150;
        private const int RedChanelDefault = 77;
        private const int LinesNumberDefault = 3;
        private const int GlassStrengthDefault = 12;
        private const int WavesEffectDefault = 50;
        private Bitmap _originalImage, _generatedImage;

        public ThirdLab()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainMenu = new MainForm();
            mainMenu.ShowDialog();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            _originalImage = new Bitmap(openFileDialog.OpenFile());
            originalPicture.Image = _originalImage;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var col1 = _originalImage.GetPixel(i, j);
                var grayColor = (redTrackBar.Value * col1.R +
                                 greenTrackBar.Value * col1.G +
                                 blueTrackBar.Value * col1.B) / 256;
                if (grayColor > 255) grayColor = 255;
                _generatedImage.SetPixel(i, j,
                    Color.FromArgb(255, grayColor, grayColor, grayColor));
            }

            generatedPicture.Image = _generatedImage;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_generatedImage == null) return;
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            switch (saveFileDialog.FilterIndex)
            {
                case 1:
                    _generatedImage.Save(saveFileDialog.FileName,
                        ImageFormat.Bmp);
                    break;
                case 2:
                    _generatedImage.Save(saveFileDialog.FileName,
                        ImageFormat.Jpeg);
                    break;
            }
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redTrackBarValue.Text = redTrackBar.Value.ToString();
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            greenTrackBarValue.Text = greenTrackBar.Value.ToString();
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            blueTrackBarValue.Text = blueTrackBar.Value.ToString();
        }

        private void resetWeightsButton_Click(object sender, EventArgs e)
        {
            // reset values in trackBars
            redTrackBar.Value = RedChanelDefault;
            greenTrackBar.Value = GreenChanelArgDefault;
            blueTrackBar.Value = BlueChanelArgDefault;

            // reset text under trackBars
            redTrackBarValue.Text = RedChanelDefault.ToString();
            greenTrackBarValue.Text = GreenChanelArgDefault.ToString();
            blueTrackBarValue.Text = BlueChanelArgDefault.ToString();
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var col1 = _originalImage.GetPixel(i, j);
                var r = 255 - col1.R;
                var g = 255 - col1.G;
                var b = 255 - col1.B;

                _generatedImage.SetPixel(i, j, Color.FromArgb(255, r, g, b));
            }

            generatedPicture.Image = _generatedImage;
        }

        private void resetLinesValue_Click(object sender, EventArgs e)
        {
            linesNumberTrackBar.Value = LinesNumberDefault;
            linesNumberText.Text = LinesNumberDefault.ToString();
            horizontalRadioButton.Checked = true;
            verticalRadioButton.Checked = false;
        }

        private void generateLinesButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;
            var linesColor = Color.Black;
            if (linesColorModal.ShowDialog() == DialogResult.OK) linesColor = linesColorModal.Color;

            _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                if ((horizontalRadioButton.Checked ? j : i) %
                    (linesNumberTrackBar.Value + 1) == 0)
                    _generatedImage.SetPixel(i, j, linesColor);
            }

            generatedPicture.Image = _generatedImage;
        }

        private void linesNumberTrackBar_Scroll(object sender, EventArgs e)
        {
            linesNumberText.Text = linesNumberTrackBar.Value.ToString();
        }

        private void resetGlassData_Click(object sender, EventArgs e)
        {
            glassStrengthText.Text = GlassStrengthDefault.ToString();
            glassStrengthTrackBar.Value = GlassStrengthDefault;

        }

        private void glassStrengthTrackBar_Scroll(object sender, EventArgs e)
        {
            glassStrengthText.Text = glassStrengthTrackBar.Value.ToString();
            secondGlassEffectRadioButton.Checked = false;
        }

        private void generateGlassEffect_Click(object sender, EventArgs e)
        {
            
            if (_originalImage == null) return;
            var randomNumber = new Random();
            _generatedImage = new Bitmap(_originalImage);
            
            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var x = i + (int)((randomNumber.NextDouble() - 0.5) * glassStrengthTrackBar.Value);
                var y = j + (int)((randomNumber.NextDouble() - 0.5) * glassStrengthTrackBar.Value);
                    
                if(x < _originalImage.Width && x >= 0 && y < _originalImage.Height && y >= 0)
                {
                    if (secondGlassEffectRadioButton.Checked)
                        _generatedImage.SetPixel(x, y, _originalImage.GetPixel(i, j));
                    else
                        _generatedImage.SetPixel(i, j, _originalImage.GetPixel(x, y));
                }
            }
            
            generatedPicture.Image = _generatedImage;
        }

        private void generateWavesEffect_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;
            
            _generatedImage = new Bitmap(_originalImage);
            
            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var x = (int)(i + xCoordinateV1TrackBar.Value*
                    Math.Sin(2 * Math.PI * j / xCoordinateV2TrackBar.Value));
                var y = (int)(j + yCoordinateV3TrackBar.Value *
                    Math.Sin(2 * Math.PI * i / yCoordinateV4TrackBar.Value));

                    
                if(x < _originalImage.Width && x >= 0 && y < _originalImage.Height && y >= 0)
                {
                    if (secondWavesEffectRadioButton.Checked)
                        _generatedImage.SetPixel(x, y, _originalImage.GetPixel(i, j));
                    else
                        _generatedImage.SetPixel(i, j, _originalImage.GetPixel(x, y));
                }
            }
            
            generatedPicture.Image = _generatedImage;
        }

        private void resetWavesEffectButton_Click(object sender, EventArgs e)
        {
            xCoordinateV1Text.Text = WavesEffectDefault.ToString();
            xCoordinateV2Text.Text = WavesEffectDefault.ToString();
            yCoordinateV3Text.Text = WavesEffectDefault.ToString();
            yCoordinateV4Text.Text = WavesEffectDefault.ToString();
            xCoordinateV1TrackBar.Value = WavesEffectDefault;
            xCoordinateV2TrackBar.Value = WavesEffectDefault;
            yCoordinateV3TrackBar.Value = WavesEffectDefault;
            yCoordinateV4TrackBar.Value = WavesEffectDefault;
            secondWavesEffectRadioButton.Checked = false;
        }

        private void xCoordinateV1TrackBar_Scroll(object sender, EventArgs e)
        {
            xCoordinateV1Text.Text = xCoordinateV1TrackBar.Value.ToString();
        }

        private void xCoordinateV2TrackBar_Scroll(object sender, EventArgs e)
        {
            xCoordinateV2Text.Text = xCoordinateV2TrackBar.Value.ToString();
        }

        private void yCoordinateV3TrackBar_Scroll(object sender, EventArgs e)
        {
            yCoordinateV3Text.Text = yCoordinateV3TrackBar.Value.ToString();
        }

        private void yCoordinateV4TrackBar_Scroll(object sender, EventArgs e)
        {
            yCoordinateV4Text.Text = yCoordinateV4TrackBar.Value.ToString();
        }
    }
}