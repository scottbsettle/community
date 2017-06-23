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

        private HomePanel   m_home   = new HomePanel();
        private SearchPanel m_Search = new SearchPanel();
        private PostPanel   m_Post   = new PostPanel();
        private Point offset    = new Point();
        private new bool MouseDown;
        public HomePage()
        {
            InitializeComponent();
            MouseDown     = false;
            m_home.Dock   = DockStyle.Fill;
            m_Search.Dock = DockStyle.Fill;
            m_Post.Dock   = DockStyle.Fill;
            PagePanel.Controls.Add(m_home);
        }
        private void resetButtonColor()
        {
            SearchButton.BackColor   = Color.Transparent;
            SearchIcon.BackColor     = Color.Transparent;
            PostIcon.BackColor       = Color.Transparent; 
            PostButton.BackColor     = Color.Transparent;
            HomeButton.BackColor     = Color.Transparent;
            HomeIcon.BackColor       = Color.Transparent;
            SettingsButton.BackColor = Color.Transparent;
            SettingsIcon.BackColor   = Color.Transparent;
            ProfileButton.BackColor  = Color.Transparent;
            ProfileIcon.BackColor    = Color.Transparent;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Interaction With the left Menubar and Icons
        #region LeftMenuButtonsAndIcons

        private void SearchButton_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            SearchButton.BackColor = Color.LightSteelBlue;
            SearchIcon.BackColor   = Color.LightSteelBlue;
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(m_Search);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            HomeButton.BackColor = Color.LightSteelBlue;
            HomeIcon.BackColor   = Color.LightSteelBlue;
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(m_home);
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            resetButtonColor();
            PostButton.BackColor = Color.LightSteelBlue;
            PostIcon.BackColor   = Color.LightSteelBlue;
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(m_Post);
        }
        #endregion
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

        // Moving the main frame when Mouse is down on top menue panel 
        #region MoveFrame
        private void TopMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            offset.X = MousePosition.X - Location.X;
            offset.Y = MousePosition.Y - Location.Y;
        }

        private void TopMenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                Point temp = new Point();
                temp.X = MousePosition.X - offset.X;
                temp.Y = MousePosition.Y - offset.Y;
                Location = temp;
            }
        }

        private void TopMenuPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }
        #endregion
    }
}
