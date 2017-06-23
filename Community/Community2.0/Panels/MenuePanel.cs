using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community2._0.Panels
{
    public partial class MenuePanel : UserControl
    {
        Color Highlight = new Color();
        public MenuePanel()
        {
            InitializeComponent();
            Highlight = Color.LightSteelBlue;
        }
        private void resetButtonColor()
        {
            SearchButton.BackColor = Color.Transparent;
            PostButton.BackColor = Color.Transparent;
            HomeButton.BackColor = Color.Transparent;
            SettingsButton.BackColor = Color.Transparent;
            ProfileButton.BackColor = Color.Transparent;
           
        }
        private void SlideButton_MouseEnter(object sender, EventArgs e)
        {
            SlideButton.BackColor = Highlight;
        }

        private void SlideButton_MouseLeave(object sender, EventArgs e)
        {
            SlideButton.BackColor = Color.Transparent;
        }
    }
}
