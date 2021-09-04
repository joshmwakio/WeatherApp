using Bunifu.UI.WinForms;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuCircleProgress1.ProgressStartCap = BunifuCircleProgress.CapStyles.Flat;
                bunifuCircleProgress2.ProgressStartCap = BunifuCircleProgress.CapStyles.Flat;
            }
            else if (bunifuDropdown1.SelectedIndex == 1)
            {
                bunifuCircleProgress1.ProgressStartCap = BunifuCircleProgress.CapStyles.Round;
                bunifuCircleProgress2.ProgressStartCap = BunifuCircleProgress.CapStyles.Round;
            }
            else if (bunifuDropdown1.SelectedIndex == 2)
            {
                bunifuCircleProgress1.ProgressStartCap = BunifuCircleProgress.CapStyles.Arrow;
                bunifuCircleProgress2.ProgressStartCap = BunifuCircleProgress.CapStyles.Arrow;
            }
            else
            {
                bunifuCircleProgress1.ProgressStartCap = BunifuCircleProgress.CapStyles.Triangle;
                bunifuCircleProgress2.ProgressStartCap = BunifuCircleProgress.CapStyles.Triangle;
            }
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuCircleProgress1.LineProgressThickness = e.Value;
            bunifuCircleProgress2.LineProgressThickness = e.Value;
            lbunifuLabel7.Text = e.Value.ToString();
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown2.SelectedIndex == 0)
            {
                bunifuCircleProgress1.ProgressEndCap = BunifuCircleProgress.CapStyles.Flat;
                bunifuCircleProgress2.ProgressEndCap = BunifuCircleProgress.CapStyles.Flat;
            }
            else if (bunifuDropdown2.SelectedIndex == 1)
            {
                bunifuCircleProgress1.ProgressEndCap = BunifuCircleProgress.CapStyles.Round;
                bunifuCircleProgress2.ProgressEndCap = BunifuCircleProgress.CapStyles.Round;
            }
            else if (bunifuDropdown2.SelectedIndex == 2)
            {
                bunifuCircleProgress1.ProgressEndCap = BunifuCircleProgress.CapStyles.Arrow;
                bunifuCircleProgress2.ProgressEndCap = BunifuCircleProgress.CapStyles.Arrow;
            }
            else
            {
                bunifuCircleProgress1.ProgressEndCap = BunifuCircleProgress.CapStyles.Triangle;
                bunifuCircleProgress2.ProgressEndCap = BunifuCircleProgress.CapStyles.Triangle;
            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
