using System;
using System.Collections.Generic;
using System.Collections;
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
    /// Interaction logic for SceneDetail.xaml
    /// </summary>
    public partial class SceneDetail : UserControl
    {

        private int lang;
        private int detail;
        


        
        public SceneDetail(int DetailNumber, int language)
        {
            InitializeComponent();



            this.lang = language;
            this.detail = DetailNumber;



            InitContent();

            if (detail == GlobalValues.DETAIL_TOP)
            {
                InitContentTop();
            }
            else if (detail == GlobalValues.DETAIL_MIDDLE)
            {
                InitContentMiddle();
            }
            else
            {
                InitContentBottom();
            }
            

            
        }


        private void InitContent()
        {
            // 공통 UI 

            TextBlock text = new TextBlock();
            text.FontSize = 20;
            text.Text = "" + lang + "scn:" + detail;
            text.Foreground = Brushes.White;
            
            Canvas.SetTop(text, 100);
            Canvas.SetLeft(text, 100);


            _cvBackground.Children.Add(text);


            Button btn = new Button();
            btn.Width = 200;
            btn.Height = 200;
            btn.Content = "Close";

            Canvas.SetLeft(btn, _cvBackground.Width - btn.Width - 100);
            Canvas.SetTop(btn, _cvBackground.Height - btn.Height - 100);


            btn.Click += new RoutedEventHandler(CloseScene);


            _cvBackground.Children.Add(btn);
            
        }


        private void InitContentTop()
        {
            // 상단부 컨텐츠
            BitmapImage img = new BitmapImage(new Uri(GlobalValues.pathStr + "text_tmp.png"));
            _imgText.Source = img;
            _imgText.Width = img.Width;
            _imgText.Height = img.Height;



            for (int i = 0; i < GlobalValues.CONTENT_COUNT_TOP; i++)
            {
                ImageButton btn = new ImageButton();
                string str = string.Format("{0:00}", i + 1);
                BitmapImage imgg = new BitmapImage(new Uri(GlobalValues.pathStr + "btn_" + str + "_normal.png"));
                btn.NormalImage = imgg;
                btn.PushedImage = new BitmapImage(new Uri(GlobalValues.pathStr + "btn_" + str + "_pressed.png"));
                btn.Tag = 100 + i;

                btn.Click += new RoutedEventHandler(ThumbnailClicked);

                Canvas.SetLeft(btn, GlobalValues.THUMB_START_MARGIN_X + (i * (imgg.Width + GlobalValues.THUMB_MARGIN)));
                Canvas.SetTop(btn, GlobalValues.THUMB_START_MARGIN_Y);

                _cvBackground.Children.Add(btn);


            }

        }

        private void InitContentMiddle()
        {
            // 중단부 컨텐츠
            BitmapImage img = new BitmapImage(new Uri(GlobalValues.pathStr + "text_tmp.png"));
            _imgText.Source = img;
            _imgText.Width = img.Width;
            _imgText.Height = img.Height;



            for (int i = 0; i < GlobalValues.CONTENT_COUNT_MIDDLE; i++)
            {
                ImageButton btn = new ImageButton();
                string str = string.Format("{0:00}", i + 1);
                BitmapImage imgg = new BitmapImage(new Uri(GlobalValues.pathStr + "btn_" + str + "_normal.png"));
                btn.NormalImage = imgg;
                btn.PushedImage = new BitmapImage(new Uri(GlobalValues.pathStr + "btn_" + str + "_pressed.png"));
                btn.Tag = 100 + i;

                btn.Click += new RoutedEventHandler(ThumbnailClicked);

                Canvas.SetLeft(btn, GlobalValues.THUMB_START_MARGIN_X + (i * (imgg.Width + GlobalValues.THUMB_MARGIN)));
                Canvas.SetTop(btn, GlobalValues.THUMB_START_MARGIN_Y);

                _cvBackground.Children.Add(btn);


            }
        }

        private void InitContentBottom()
        {
            // 하단부 컨텐츠 
            BitmapImage img = new BitmapImage(new Uri(GlobalValues.pathStr + "text_tmp.png"));
            _imgText.Source = img;
            _imgText.Width = img.Width;
            _imgText.Height = img.Height;



            for (int i = 0; i < GlobalValues.CONTENT_COUNT_BOTTOM; i++)
            {
                ImageButton btn = new ImageButton();
                string str = string.Format("{0:00}", i + 1);
                BitmapImage imgg = new BitmapImage(new Uri(GlobalValues.pathStr + "btn_" + str + "_normal.png"));
                btn.NormalImage = imgg;
                btn.PushedImage = new BitmapImage(new Uri(GlobalValues.pathStr + "btn_" + str + "_pressed.png"));
                btn.Tag = 100 + i;

                btn.Click += new RoutedEventHandler(ThumbnailClicked);

                Canvas.SetLeft(btn, GlobalValues.THUMB_START_MARGIN_X + (i * (imgg.Width + GlobalValues.THUMB_MARGIN)));
                Canvas.SetTop(btn, GlobalValues.THUMB_START_MARGIN_Y);

                _cvBackground.Children.Add(btn);


            }

        }

        private void CloseScene(object sender, RoutedEventArgs e)
        {


            ((Canvas)this.Parent).Children.Remove(this);


        }



        private void ThumbnailClicked(object sender, RoutedEventArgs e)
        {

            //if (_cvImageViewer.Children.Count != 0)
            //{
            //    ImageViewer tmp = (ImageViewer)_cvImageViewer.Children[_cvImageViewer.Children.Count - 1];
            //    tmp.CloseImage();
            //}


            foreach (UIElement child in _cvImageViewer.Children)
            {
                ImageViewer tmp = (ImageViewer)child;
                if (!tmp.IsClosing) tmp.CloseImage();

            }

            int imgNo = (int)((ImageButton)sender).Tag;
            ImageViewer iv = new ImageViewer(imgNo);
            _cvImageViewer.Children.Add(iv);
            iv.ShowImage();
        }
    }



}
