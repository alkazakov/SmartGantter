﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace SmartGantter
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RadRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadRibbonWindow_Closed(object sender, System.EventArgs e)
        {
            Process.GetCurrentProcess().Kill();

        }
    }
}
