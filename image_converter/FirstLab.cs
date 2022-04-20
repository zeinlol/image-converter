using System;
using System.Drawing;
using System.Windows.Forms;

namespace image_converter
{
    public partial class FirstLab : Form
    {
        private Bitmap _originalImage, _redImageChanel, _greenImageChanel, _blueImageChanel;

        public FirstLab()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainMenu = new MainForm();
            mainMenu.ShowDialog();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            _originalImage = new Bitmap(openFileDialog.OpenFile());
            originalPictureBox.Image = _originalImage;
        }

        private void disperseButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _redImageChanel = new Bitmap(_originalImage);
            _greenImageChanel = new Bitmap(_originalImage);
            _blueImageChanel = new Bitmap(_originalImage);

            for (var i = 0; i < _originalImage.Width; i++)
            for (var j = 0; j < _originalImage.Height; j++)
            {
                var col1 = _originalImage.GetPixel(i, j);
                int r = col1.R;
                int g = col1.G;
                int b = col1.B;

                _redImageChanel.SetPixel(i, j, Color.FromArgb(255, r, 0, 0));
                _greenImageChanel.SetPixel(i, j, Color.FromArgb(255, 0, g, 0));
                _blueImageChanel.SetPixel(i, j, Color.FromArgb(255, 0, 0, b));
            }

            redPictureBox.Image = _redImageChanel;
            bluePictureBox.Image = _greenImageChanel;
            greenPictureBox.Image = _blueImageChanel;
        }

        private void originalPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (_originalImage == null) return; //Handle if no image

            RGBTextBox.Text = _originalImage.GetPixel(e.X, e.Y).ToString();
            HexTextBox.Text = _originalImage.GetPixel(e.X, e.Y).ToArgb().ToString("X");
            NumberTextBox.Text = _originalImage.GetPixel(e.X, e.Y).ToArgb().ToString();
        }
    }
}