using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community2._0
{
    public partial class HomePage : Form
    {

        private HomePanel m_home = new HomePanel();
        private SearchPanel m_Search = new SearchPanel();
        public HomePage()
        {
            InitializeComponent();
            m_home.Dock = DockStyle.Fill;
            m_Search.Dock = DockStyle.Fill;
            PagePanel.Controls.Add(m_home);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            IconPanel.Visible = true;
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(m_Search);
        }

        private void SlideButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            IconPanel.Visible = true;
        }

        private void slideButtonIcon_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            IconPanel.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(m_home);
        }
    }
}
