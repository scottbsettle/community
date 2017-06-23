using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community2._0
{
    public partial class HomePanel : UserControl
    {
        private Size Small = new Size(139, 127);
        private Size Large = new Size(149, 137);
       
        public HomePanel()
        {
            InitializeComponent();
           
        }

        private void ProfileIcon_MouseEnter(object sender, EventArgs e)
        {
            ProfileIcon.Size = Large;
        }

        private void ProfileIcon_MouseLeave(object sender, EventArgs e)
        {
            ProfileIcon.Size = Small;
        }

        private void PostIcon_MouseEnter(object sender, EventArgs e)
        {
            PostIcon.Size = Large;
        }

        private void PostIcon_MouseLeave(object sender, EventArgs e)
        {
            PostIcon.Size = Small;
        }

        private void SearchIcon_MouseEnter(object sender, EventArgs e)
        {
            SearchIcon.Size = Large;
        }

        private void SearchIcon_MouseLeave(object sender, EventArgs e)
        {
            SearchIcon.Size = Small;
        }

        private void SettingsIcon_MouseEnter(object sender, EventArgs e)
        {
            SettingsIcon.Size = Large;
        }

        private void SettingsIcon_MouseLeave(object sender, EventArgs e)
        {
            SettingsIcon.Size = Small;
        }
    }
}
