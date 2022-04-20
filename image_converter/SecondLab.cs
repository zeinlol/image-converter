using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace image_converter
{
    public partial class SecondLab : Form
    {
        private readonly int _blueChanelArgDefault = 29;
        private readonly int _greenChanelArgDefault = 150;
        private readonly int _redChanelDefault = 77;
        private Bitmap _originalImage, _generatedImage;

        public SecondLab()
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

            RegenerateImage();
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

        private void RegenerateImage()
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

        private void resetWeightsButton_Click(object sender, EventArgs e)
        {
            // reset values in trackBars
            redTrackBar.Value = _redChanelDefault;
            greenTrackBar.Value = _greenChanelArgDefault;
            blueTrackBar.Value = _blueChanelArgDefault;

            // reset text under trackBars
            redTrackBarValue.Text = _redChanelDefault.ToString();
            greenTrackBarValue.Text = _greenChanelArgDefault.ToString();
            blueTrackBarValue.Text = _blueChanelArgDefault.ToString();
            RegenerateImage();
        }
    }
}