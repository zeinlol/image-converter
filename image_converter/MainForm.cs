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
            OpenLab(new FirstLab());
        }

        private void lab2Button_Click(object sender, EventArgs e)
        {
            OpenLab(new SecondLab());
        }

        private void lab3Button_Click(object sender, EventArgs e)
        {
            OpenLab(new ThirdLab());
        }

        private void Lab4Button_Click(object sender, EventArgs e)
        {
            OpenLab(new FourthLab());
        }

        private void lab5Button_Click(object sender, EventArgs e)
        {
            OpenLab(new FifthLab());
        }

        private void lab6Sixth_Click(object sender, EventArgs e)
        {
            OpenLab(new SixthLab());
        }

        private void OpenLab(Form labForm)
        {
            Hide();
            labForm.ShowDialog();
        }
    }
}