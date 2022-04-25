using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace image_converter
{
    public partial class SixthLab : Form
    {
        private int _filterSize = 3;
        private Bitmap _originalImage, _generatedImage;

        public SixthLab()
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

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;
            
            _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var mediumValues = new GetPixelAround(_originalImage, i, j, _filterSize);
                var r = mediumValues.Red();
                var g = mediumValues.Green();
                var b = mediumValues.Blue();

                _generatedImage.SetPixel(i, j, Color.FromArgb(255, r, g, b));
            }

            resultPictureBox.Image = _generatedImage;
        }


        private void threeRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (threeRangeCheckBox.Checked)
            {
                fiveRangeCheckBox.Checked = false;
                sevenRangeCheckBox.Checked = false;
                _filterSize = 3;
            }
            else if (!fiveRangeCheckBox.Checked && !sevenRangeCheckBox.Checked)
                threeRangeCheckBox.Checked = true;
        }

        private void fiveRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fiveRangeCheckBox.Checked)
            {
                threeRangeCheckBox.Checked = false;
                sevenRangeCheckBox.Checked = false;
                _filterSize = 5;
            }
            else if (!threeRangeCheckBox.Checked && !sevenRangeCheckBox.Checked)
                fiveRangeCheckBox.Checked = true;
        }

        private void sevenRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sevenRangeCheckBox.Checked)
            {
                fiveRangeCheckBox.Checked = false;
                threeRangeCheckBox.Checked = false;
                _filterSize = 7;
            }
            else if (!fiveRangeCheckBox.Checked && !threeRangeCheckBox.Checked)
                sevenRangeCheckBox.Checked = true;
        }
    }
    public readonly struct GetPixelAround
    {
        private readonly int[] _arrayRed, _arrayGreen, _arrayBlue;
        private readonly int _middlePoint;

        public GetPixelAround(Bitmap targetImage, int targetX, int targetY, int filterSize)
        {
            var arrayLength = filterSize * filterSize;
            _middlePoint = (arrayLength - 1) / 2;
            _arrayRed = new int[arrayLength];
            _arrayGreen = new int[arrayLength];
            _arrayBlue = new int[arrayLength];
            var rangeSize = (filterSize - 1) / 2; // for 3 is 1  for 5 is 2  for 7 is 3
            for (var k = -rangeSize; k <= rangeSize; k++)
            for (var p = -rangeSize; p <= rangeSize; p++)
            {
                var x = GetCoordinate(targetX, k, targetImage.Width);
                var y = GetCoordinate(targetY, p, targetImage.Height);
                var col = targetImage.GetPixel(x, y);

                _arrayRed[filterSize * (k + rangeSize) + p + rangeSize] = col.R;
                _arrayGreen[filterSize * (k + rangeSize) + p + rangeSize] = col.G;
                _arrayBlue[filterSize * (k + rangeSize) + p + rangeSize] = col.B;
            }

            Array.Sort(_arrayRed);
            Array.Sort(_arrayGreen);
            Array.Sort(_arrayBlue);
        }

        private static int GetCoordinate(int targetImageCoordinate, int targetValue, int maxValue)
        {
            var value = targetImageCoordinate + targetValue;
            if (value < 0)
                return 0;
            return value > maxValue - 1 ? maxValue - 1 : value; // index from 0, value from 1
        }

        public int Red()
        {
            return _arrayRed[_middlePoint];
        }

        public int Green()
        {
            return _arrayGreen[_middlePoint];
        }

        public int Blue()
        {
            return _arrayBlue[_middlePoint];
        }
    }
}