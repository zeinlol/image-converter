using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace image_converter
{
    public partial class FourthLab : Form
    {
        private const int InclineValueDefault = 1;
        private Bitmap _originalImage, _generatedImage;
        private double _rotateValue;

        public FourthLab()
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

        private void resetInclineData_Click(object sender, EventArgs e)
        {
            inclineXArgValue.Text = InclineValueDefault.ToString();
            inclineYArgValue.Text = InclineValueDefault.ToString();
            inclineXArgTrackBar.Value = InclineValueDefault;
            inclineYArgTrackBar.Value = InclineValueDefault;
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH",
            MessageId = "type: System.ArgumentOutOfRangeException")]
        private void generateInclineEffect_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;
            // handle divide by zero
            if (inclineXArgTrackBar.Value == 1 && inclineYArgTrackBar.Value == 1)
            {
                generatedPicture.Image = _originalImage;
                return;
            }

            _generatedImage = new Bitmap(_originalImage.Width, _originalImage.Height);
            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                // i = x + ay  ;  j = bx + y
                // -> x = ay - i; y = bx - j
                // --> y = b(ay - i) - j  -->  y - bay = -bi - j -->  y(ba - 1) = bi + j
                // --> y = (bi + j) / (ba - 1)
                //     x = ay - i
                var y = (inclineXArgTrackBar.Value * i + j) /
                        (inclineXArgTrackBar.Value * inclineYArgTrackBar.Value - 1);
                var x = inclineYArgTrackBar.Value * y - i;
                try
                {
                    _generatedImage.SetPixel(x, y, _originalImage.GetPixel(i, j));
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }

            generatedPicture.Image = _generatedImage;
        }

        private void rotateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!rotateTextBox.Text.All(char.IsDigit)) return;
            try
            {
                var rotate = int.Parse(rotateTextBox.Text);
                if (rotate > 360)
                {
                    rotateTextBox.Text = "360";
                    rotate = 360;
                }

                else if (rotate < 0)
                {
                    rotateTextBox.Text = "0";
                    rotate = 0;
                }

                _rotateValue = rotate * Math.PI / 180;
            }
            catch (FormatException)
            {
                _rotateValue = 0;
                rotateTextBox.ResetText();
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            // generate possible largest image when rotate 
            var hypotenuse = (int)Math.Sqrt(_originalImage.Width * _originalImage.Width +
                                            _originalImage.Height * _originalImage.Width);
            _generatedImage = new Bitmap(hypotenuse, hypotenuse);

            var originalCentralX = _originalImage.Width / 2;
            var originalCentralY = _originalImage.Height / 2;
            var generatedCentralX = _generatedImage.Width / 2;
            var generatedCentralY = _generatedImage.Height / 2;
            var moveX = generatedCentralX - originalCentralX;
            var moveY = generatedCentralY - originalCentralY;

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var x = (i - originalCentralX) * Math.Cos(_rotateValue) -
                    (j - originalCentralY) * Math.Sin(_rotateValue) + originalCentralX;
                var y = -(i - originalCentralX) * Math.Sin(_rotateValue) -
                    (j - originalCentralY) * Math.Cos(_rotateValue) + originalCentralY;

                // add moveX and moveY for moving rotated original image to the center of generated
                _generatedImage.SetPixel((int)x + moveX, (int)y + moveY, _originalImage.GetPixel(i, j));
            }

            generatedPicture.Image = _generatedImage;
        }

        private void mirrorVerticalButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _generatedImage.Width; i++)
            for (var j = 0; j < _generatedImage.Height; j++)
            {
                var x = _generatedImage.Width - i;
                try
                {
                    _generatedImage.SetPixel(x, j, _originalImage.GetPixel(i, j));
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }

            generatedPicture.Image = _generatedImage;
        }

        private void mirrorHorizontalButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _generatedImage.Width; i++)
            for (var j = 0; j < _generatedImage.Height; j++)
            {
                var y = _generatedImage.Height - j;
                try
                {
                    _generatedImage.SetPixel(i, y, _originalImage.GetPixel(i, j));
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }

            generatedPicture.Image = _generatedImage;
        }

        private void inclineXArgTrackBar_Scroll(object sender, EventArgs e)
        {
            inclineXArgValue.Text = inclineXArgTrackBar.Value.ToString();
        }

        private void inclineYArgTrackBar_Scroll(object sender, EventArgs e)
        {
            inclineYArgValue.Text = inclineYArgTrackBar.Value.ToString();
        }
    }
}