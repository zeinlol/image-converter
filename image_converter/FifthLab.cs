using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace image_converter
{
    public partial class FifthLab : Form
    {
        private const int DefaultBrightness = 0;
        private const int DefaultColorMinHistogram = 0;
        private const int DefaultColorMaxHistogram = 255;
        private long _blueBucket;
        private long _blueMedium;
        private long _greenBucket;
        private long _greenMedium;
        private int[] _histogramBlue = new int[256];
        private int[] _histogramGreen = new int[256];
        private int[] _histogramRed = new int[256];

        private Bitmap _originalImage, _generatedImage;
        private long _pixelCount;
        private long _redBucket;
        private long _redMedium;


        public FifthLab()
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
            GenerateHistograms(_originalImage);
            FillMediumValues();
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

            if (_generatedImage == null) _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var col1 = _originalImage.GetPixel(i, j);

                int r = col1.R;
                int g = col1.G;
                int b = col1.B;

                if (brightnessTrackBar.Value != 0)
                {
                    r = AdjustColorBrightness(r);
                    g = AdjustColorBrightness(g);
                    b = AdjustColorBrightness(b);
                }

                _generatedImage.SetPixel(i, j, Color.FromArgb(255, r, g, b));
            }

            originalPicture.Image = _generatedImage;
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: bucket[]")]
        private void GenerateHistograms(Bitmap targetPicture)
        {
            ResetHistogram();
            for (var i = 0; i < targetPicture.Width; i++)
            for (var j = 0; j < targetPicture.Height; j++)
                FillHistograms(targetPicture.GetPixel(i, j));

            SetHistograms(redChanelChart, _histogramRed);
            SetHistograms(greenChanelChart, _histogramGreen);
            SetHistograms(blueChanelChart, _histogramBlue);
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH",
            MessageId = "type: System.Windows.Forms.DataVisualization.Charting.DataPoint")]
        private void FillHistograms(Color pixel)
        {
            _histogramRed[pixel.R]++;
            _histogramGreen[pixel.G]++;
            _histogramBlue[pixel.B]++;
        }

        private void ResetHistogram()
        {
            _histogramRed = new int[256];
            _histogramGreen = new int[256];
            _histogramBlue = new int[256];
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: bucket[]")]
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH",
            MessageId = "type: System.Collections.Hashtable")]
        private static void SetHistograms(Chart colorChart, IList<int> colorArray)
        {
            colorChart.Series["Series1"].Points.Clear();
            foreach (var t in colorArray)
                colorChart.Series["Series1"].Points.AddY(t);
        }

        private int AdjustColorBrightness(int pixelColor)
        {
            var brightness = brightnessTrackBar.Value * 2.55; // trackbar value is in percents 
            var pixelResult = pixelColor + brightness; // if brightness < 0 then + (- value)
            if (pixelResult < 0)
                pixelResult = 0;
            else if (pixelResult > 255)
                pixelResult = 255;
            return (int)pixelResult;
        }

        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            brightnesValueText.Text = brightnessTrackBar.Value.ToString();
        }

        private void resetInput_Click(object sender, EventArgs e)
        {
            brightnesValueText.Text = DefaultBrightness.ToString();
            brightnessTrackBar.Value = DefaultBrightness;
            redMaxTextBox.Text = DefaultColorMaxHistogram.ToString();
            greenMaxTextBox.Text = DefaultColorMaxHistogram.ToString();
            blueMaxTextBox.Text = DefaultColorMaxHistogram.ToString();
            redMinTextBox.Text = DefaultColorMinHistogram.ToString();
            greenMinTextBox.Text = DefaultColorMinHistogram.ToString();
            blueMinTextBox.Text = DefaultColorMinHistogram.ToString();
            _generatedImage = _originalImage;
            originalPicture.Image = _originalImage;
        }

        private void lineHistogramCorrectionButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _generatedImage = new Bitmap(_originalImage);

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var col1 = _originalImage.GetPixel(i, j);

                var r = CalculateColorByHistogram(
                    col1.R,
                    Convert.ToInt32(redMinTextBox.Text),
                    Convert.ToInt32(redMaxTextBox.Text));
                var g = CalculateColorByHistogram(
                    col1.G,
                    Convert.ToInt32(greenMinTextBox.Text),
                    Convert.ToInt32(greenMaxTextBox.Text));
                var b = CalculateColorByHistogram(
                    col1.B,
                    Convert.ToInt32(blueMinTextBox.Text),
                    Convert.ToInt32(blueMaxTextBox.Text));

                _generatedImage.SetPixel(i, j, Color.FromArgb(255, r, g, b));
            }

            GenerateHistograms(_generatedImage);
            originalPicture.Image = _generatedImage;
        }

        private static int CalculateColorByHistogram(int color, int minValue, int maxValue)
        {
            var result = (color - minValue) * 255 / (maxValue - minValue);
            if (result < 0) return 0;
            return result > 255 ? 255 : result;
        }

        private void medianGreyCorrection_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;
            if (_generatedImage == null) _generatedImage = new Bitmap(_originalImage);
            
            var averageGrey = (_redMedium + _greenMedium + _blueMedium) / 3;

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var col1 = _originalImage.GetPixel(i, j);

                var r = CalculateGreyMediumColor((int)averageGrey, col1.R, (int)_redMedium);
                var g = CalculateGreyMediumColor((int)averageGrey, col1.G, (int)_greenMedium);
                var b = CalculateGreyMediumColor((int)averageGrey, col1.B, (int)_blueMedium);

                _generatedImage.SetPixel(i, j, Color.FromArgb(255, r, g, b));
            }

            GenerateHistograms(_generatedImage);
            originalPicture.Image = _generatedImage;
        }

        private void FillMediumValues()
        {
            _redBucket = 0;
            _greenBucket = 0;
            _blueBucket = 0;
            _pixelCount = 0;

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var color = _originalImage.GetPixel(i, j);

                _pixelCount++;
                _redBucket += color.R;
                _greenBucket += color.G;
                _blueBucket += color.B;
            }

            _redMedium = _redBucket / _pixelCount;
            _greenMedium = _greenBucket / _pixelCount;
            _blueMedium = _blueBucket / _pixelCount;
        }

        private static int CalculateGreyMediumColor(int greyColor, int targetColor, int targetColorMedium)
        {
            int result;
            if (targetColorMedium == 0)
                result = targetColor * greyColor;
            else result = targetColor * greyColor / targetColorMedium;
            if (result < 0) return 0;
            return result > 255 ? 255 : result;
        }
    }
}