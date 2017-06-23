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
        private Point       offset   = new Point();
        private Panels.MenuePanel     m_Menu = new Panels.MenuePanel();
        private Panels.MenueIconPanel m_Icon = new Panels.MenueIconPanel();
        private Panel m_PagePanel = new Panel();
        private new bool MouseDown;
        private bool IMenuSelect;
        public HomePage()
        {
            InitializeComponent();
            m_PagePanel = PagePanel;
            MouseDown        = false;
            IMenuSelect = false;
            m_home.Dock      = DockStyle.Fill;
            m_Search.Dock    = DockStyle.Fill;
            m_Post.Dock      = DockStyle.Fill;
            m_Menu.Dock = DockStyle.Left;
            m_Icon.Dock = DockStyle.Left;
            m_PagePanel.Controls.Add(m_home);
            PagePanel.Controls.Add(m_Menu);
            
        }
        public void RemoveMenu()
        {
            if (IMenuSelect)
            {
                PagePanel.Controls.Remove(m_Icon);
                IMenuSelect = false;
            }
            else
            {
                PagePanel.Controls.Remove(m_Menu);
                IMenuSelect = true;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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
     
    }
}
