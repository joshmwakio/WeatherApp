using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu_Circle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            Random random = new Random();
            if (e.Value < 45)
            {
                bunifuCircleProgress1.ValueByTransition = random.Next(10, 18);
                bunifuCircleProgress1.SubScriptText = "Low";
                weatherPictureBox.Image = Bunifu_Circle.Properties.Resources.gifrain;
            }
            else if(e.Value>46 && e.Value < 60)
            {
                bunifuCircleProgress1.ValueByTransition = random.Next(20, 55);
                bunifuCircleProgress1.SubScriptText = "Clear";
                weatherPictureBox.Image = Bunifu_Circle.Properties.Resources.gifsun;
            }
            else
            {
                bunifuCircleProgress1.ValueByTransition = random.Next(10, 18);
                bunifuCircleProgress1.SubScriptText = "Storm";
                weatherPictureBox.Image = Bunifu_Circle.Properties.Resources.giflght;
            }
        }
    }
}
