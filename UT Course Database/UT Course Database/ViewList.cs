﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT_Course_Database
{
    public partial class ViewList : Form
    {

        public ViewList()
        {
            InitializeComponent();
        }
        public void setText(string text)
        {
            rtbViewList.Text = text;
        }
    }
}
