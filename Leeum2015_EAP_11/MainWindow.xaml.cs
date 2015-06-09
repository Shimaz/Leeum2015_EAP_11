﻿using System;
using System.Collections.Generic;
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

namespace Leeum2015_EAP_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 1 Depth Image - List, 2 Depth Image Text 
    /// 
    /// 2 Depth Info Gallery
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SceneHome sh = new SceneHome(GlobalValues.LANG_KOR);
            Canvas.SetTop(sh, 0);
            Canvas.SetLeft(sh, 0);

            _cvBasd.Children.Add(sh);

            
        }
    }
}
