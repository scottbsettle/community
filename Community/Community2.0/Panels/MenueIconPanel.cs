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
    public partial class MenueIconPanel : UserControl
    {
        Color Highlight = new Color();
        public MenueIconPanel()
        {
            InitializeComponent();
        }
        private void resetButtonColor()
        {

            Highlight = Color.LightSteelBlue;
            SearchIcon.BackColor = Color.Transparent;
            PostIcon.BackColor = Color.Transparent;
            HomeIcon.BackColor = Color.Transparent;
            SettingsIcon.BackColor = Color.Transparent;
            ProfileIcon.BackColor = Color.Transparent;
        }
       

        private void SlideButtonIcon_MouseEnter(object sender, EventArgs e)
        {
            SlideButtonIcon.BackColor = Highlight;
        }

        private void HomeIcon_MouseEnter(object sender, EventArgs e)
        {
            HomeIcon.BackColor = Highlight;
        }

        private void SearchIcon_MouseEnter(object sender, EventArgs e)
        {
            SearchIcon.BackColor = Highlight;
        }

        private void PostIcon_MouseEnter(object sender, EventArgs e)
        {
            PostIcon.BackColor = Highlight;
        }

        private void ProfileIcon_MouseEnter(object sender, EventArgs e)
        {
            ProfileIcon.BackColor = Highlight;
        }

        private void SettingsIcon_MouseEnter(object sender, EventArgs e)
        {
            SettingsIcon.BackColor = Highlight;
        }

        private void SettingsIcon_MouseLeave(object sender, EventArgs e)
        {
            SettingsIcon.BackColor = Color.Transparent;
        }

        private void ProfileIcon_MouseLeave(object sender, EventArgs e)
        {
            ProfileIcon.BackColor = Color.Transparent;
        }

        private void PostIcon_MouseLeave(object sender, EventArgs e)
        {
            PostIcon.BackColor = Color.Transparent;
        }

        private void SearchIcon_MouseLeave(object sender, EventArgs e)
        {
            SearchIcon.BackColor = Color.Transparent;
        }

        private void HomeIcon_MouseLeave(object sender, EventArgs e)
        {
            HomeIcon.BackColor = Color.Transparent;
        }

        private void SlideButtonIcon_MouseLeave(object sender, EventArgs e)
        {
            SlideButtonIcon.BackColor = Color.Transparent;
        }

    }
}
