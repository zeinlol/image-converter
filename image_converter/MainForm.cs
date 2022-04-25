using System;
using System.Windows.Forms;

namespace image_converter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lab1Button_Click(object sender, EventArgs e)
        {
            var firstLabForm = new FirstLab();
            Hide();
            firstLabForm.ShowDialog();
        }

        private void lab2Button_Click(object sender, EventArgs e)
        {
            var secondLabForm = new SecondLab();
            Hide();
            secondLabForm.ShowDialog();
        }

        private void lab3Button_Click(object sender, EventArgs e)
        {
            var thirdLabForm = new ThirdLab();
            Hide();
            thirdLabForm.ShowDialog();
        }

        private void Lab4Button_Click(object sender, EventArgs e)
        {
            var fourthLabForm = new FourthLab();
            Hide();
            fourthLabForm.ShowDialog();
        }

        private void lab5Button_Click(object sender, EventArgs e)
        {
            var fifthLabForm = new FifthLab();
            Hide();
            fifthLabForm.ShowDialog();
        }
    }
}