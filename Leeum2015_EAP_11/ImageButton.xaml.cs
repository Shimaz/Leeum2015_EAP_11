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
using System.Windows.Media.Animation;

namespace Leeum2015_EAP_11
{
    /// <summary>
    /// Interaction logic for ImageButton.xaml
    /// </summary>
    public partial class ImageButton : UserControl
    {


        //private bool isButtonEnabled = true;

        public ImageSource DisabledImage
        {
            get { return (ImageSource)GetValue(DisabledImageProperty); }
            set { SetValue(DisabledImageProperty, value); }
        }
        public static readonly DependencyProperty DisabledImageProperty =
            DependencyProperty.Register("DisabledImage", typeof(ImageSource), typeof(ImageButton), new UIPropertyMetadata(null));


        public ImageSource NormalImage
        {
            get { return (ImageSource)GetValue(NormalImageProperty); }
            set { SetValue(NormalImageProperty, value); }
        }


        public static readonly DependencyProperty NormalImageProperty =
            DependencyProperty.Register("NormalImage", typeof(ImageSource), typeof(ImageButton), new UIPropertyMetadata(null));


        public ImageSource PushedImage
        {
            get { return (ImageSource)GetValue(PushedImageProperty); }
            set { SetValue(PushedImageProperty, value); }
        }

        public static readonly DependencyProperty PushedImageProperty =
            DependencyProperty.Register("PushedImage", typeof(ImageSource), typeof(ImageButton), new UIPropertyMetadata(null));



        public void showButton(double delayTime)
        {

            _baseCanvas.IsEnabled = true;

            DoubleAnimation showAni = new DoubleAnimation();
            showAni.From = 0;
            showAni.To = 1;
            SineEase s = new SineEase();
            s.EasingMode = EasingMode.EaseInOut;
            showAni.EasingFunction = s;
            showAni.Duration = new Duration(TimeSpan.FromSeconds(0.35));
            showAni.BeginTime = TimeSpan.FromSeconds(delayTime);

            button.BeginAnimation(Canvas.OpacityProperty, showAni);
            

        }

        public void showButton()
        {
            _baseCanvas.IsEnabled = true;

            DoubleAnimation showAni = new DoubleAnimation();
            showAni.From = 0;
            showAni.To = 1;
            SineEase s = new SineEase();
            s.EasingMode = EasingMode.EaseInOut;
            showAni.EasingFunction = s;
            showAni.Duration = new Duration(TimeSpan.FromSeconds(0.35));

            button.BeginAnimation(Canvas.OpacityProperty, showAni);
        }

        


        public void hideButton()
        {
            DoubleAnimation hideAni = new DoubleAnimation();
            hideAni.From = 1;
            hideAni.To = 0;
            SineEase s = new SineEase();
            s.EasingMode = EasingMode.EaseInOut;
            hideAni.EasingFunction = s;
            hideAni.Duration = new Duration(TimeSpan.FromSeconds(0.2));

            hideAni.Completed += new EventHandler(hideCompleted);

            button.BeginAnimation(Canvas.OpacityProperty, hideAni);
        }

        private void hideCompleted(object sender, EventArgs e)
        {
            _baseCanvas.IsEnabled = false;
        }


        

        public event RoutedEventHandler Click;

        public ImageButton()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }
        }
    }
}
