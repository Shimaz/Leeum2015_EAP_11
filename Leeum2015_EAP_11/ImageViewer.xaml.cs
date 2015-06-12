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
    /// Interaction logic for ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : UserControl
    {

        public bool IsClosing = false;

        public ImageViewer()
        {
            InitializeComponent();
        }

        public ImageViewer(int imgNo)
        {
            InitializeComponent();
        }

        public void ShowImage()
        {


        }

        public void CloseImage()
        {
            IsClosing = true;

        }


        private void RemoveSelf()
        {

            ((Canvas)this.Parent).Children.Remove(this);

        }
    }
}
