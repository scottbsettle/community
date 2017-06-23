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
    public partial class PostPanel : UserControl
    {
        private PostCatPanel  m_CatP  = new PostCatPanel();
        private PostCustPanel m_CustP = new PostCustPanel();
        private PostImgPanel  m_ImgP  = new PostImgPanel();
        public PostPanel()
        {
            InitializeComponent();
            m_CatP.Dock = DockStyle.Fill;
            m_CustP.Dock = DockStyle.Fill;
            m_ImgP.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(m_CatP);
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(m_CatP);
        }

        private void CustButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(m_CustP);
        }

        private void ImgButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(m_ImgP);
        }
    }
}
