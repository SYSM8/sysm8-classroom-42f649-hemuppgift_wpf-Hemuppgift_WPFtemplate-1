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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WrapWindow.xaml
    /// </summary>
    public partial class WrapWindow : Window
    {
        public WrapWindow()
        {
            InitializeComponent();
        }

        private void VertiBtn1_Checked(object sender, RoutedEventArgs e)
        {
            wrapGift.Orientation = Orientation.Vertical;
        }

        private void HoriBtn1_Checked(object sender, RoutedEventArgs e)
        {
            wrapGift.Orientation=Orientation.Horizontal;
        }
    }
}
