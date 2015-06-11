using System;
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
        }

        private void InitContentMiddle()
        {
            // 중단부 컨텐츠
        }

        private void InitContentBottom()
        {
            // 하단부 컨텐츠 


        }

        private void CloseScene(object sender, RoutedEventArgs e)
        {


            ((Canvas)this.Parent).Children.Remove(this);


        }
    }



}
