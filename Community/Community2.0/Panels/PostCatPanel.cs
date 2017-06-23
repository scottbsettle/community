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
    public partial class PostCatPanel : UserControl
    {
        public PostCatPanel()
        {
            InitializeComponent();
        }

        private void SlideButtonIcon_Click(object sender, EventArgs e)
        {
            CatPanel.Visible = true;
           SlidePanel.Visible = false;
        }

        private void SlideButton_Click(object sender, EventArgs e)
        {
            CatPanel.Visible = false;
            SlidePanel.Visible = true;
        }
    }
}
