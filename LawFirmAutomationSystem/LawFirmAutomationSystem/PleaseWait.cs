﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawFirmAutomationSystem
{
    public partial class PleaseWait : MaterialForm
    {
        public PleaseWait()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.loading;
        }
    }
}
