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
    /// Interaction logic for SceneHome.xaml
    /// </summary>
    public partial class SceneHome : UserControl
    {


        private string pathStr = "pack://application:,,,/Resources/";

        public int lang = GlobalValues.LANG_KOR;

        public SceneHome(int Language)
        {
            InitializeComponent();
            InitContents();
        }


        public void InitContents()
        {
         
            ImageButton btn01 = new ImageButton();
            ImageButton btn02 = new ImageButton();
            ImageButton btn03 = new ImageButton();

            btn01.NormalImage = new BitmapImage(new Uri(pathStr + "btn_tmp_normal.png"));
            btn01.PushedImage = new BitmapImage(new Uri(pathStr + "btn_tmp_pressed.png"));


            btn01.Click += new RoutedEventHandler(openDetail);
            btn01.Tag = GlobalValues.DETAIL_TOP;

            Canvas.SetTop(btn01, 100);
            Canvas.SetLeft(btn01, 100);
            _cvBaseHome.Children.Add(btn01);


            btn02.NormalImage = new BitmapImage(new Uri(pathStr + "btn_tmp_normal.png"));
            btn02.PushedImage = new BitmapImage(new Uri(pathStr + "btn_tmp_pressed.png"));


            btn02.Click += new RoutedEventHandler(openDetail);
            btn02.Tag = GlobalValues.DETAIL_MIDDLE;

            Canvas.SetTop(btn02, 500);
            Canvas.SetLeft(btn02, 100);
            _cvBaseHome.Children.Add(btn02);




            btn03.NormalImage = new BitmapImage(new Uri(pathStr + "btn_tmp_normal.png"));
            btn03.PushedImage = new BitmapImage(new Uri(pathStr + "btn_tmp_pressed.png"));


            btn03.Click += new RoutedEventHandler(openDetail);
            btn03.Tag = GlobalValues.DETAIL_BOTTOM;

            Canvas.SetTop(btn03, 900);
            Canvas.SetLeft(btn03, 100);
            _cvBaseHome.Children.Add(btn03);

            

        }

        public void openDetail(object sender, RoutedEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            int detail = (int)btn.Tag;


            // 

            SceneDetail scDetail = new SceneDetail(detail, lang);



            _cvBaseHome.Children.Add(scDetail);


               
            


        }
        
    }
}
