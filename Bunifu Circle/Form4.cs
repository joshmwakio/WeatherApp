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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuCircleProgress2_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuVSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            bunifuCircleProgress1.CircleMargin = e.Value;
            bunifuCircleProgress2.CircleMargin = e.Value;
            mbunifuLabel.Text = e.Value.ToString();
        }

        private void bunifuVSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            bunifuCircleProgress1.LineThickness = e.Value;
            bunifuCircleProgress2.LineThickness = e.Value;
            lbunifuLabel.Text = e.Value.ToString();
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
