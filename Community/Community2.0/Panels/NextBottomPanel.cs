﻿using System;
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
    public partial class NextBottomPanel : UserControl
    {
        public NextBottomPanel()
        {
            InitializeComponent();
        }

        public void ChangeButtonTxt(string txt)
        {
            NextButton.Text = txt;
        }
    }
}
