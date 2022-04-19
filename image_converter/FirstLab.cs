using System;
using System.Windows.Forms;

namespace image_converter
{
    public partial class FirstLab : Form
    {
        public FirstLab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            this.Hide();
            var mainMenu = new MainForm();
            mainMenu.Show(); 
        }
    }
}