using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridBtn_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void StackBtn_Click(object sender, RoutedEventArgs e)
        {
            StackWindow stackWindow = new StackWindow();
            stackWindow.Show();
        }

        private void WrapBtn_Click(object sender, RoutedEventArgs e)
        {
            WrapWindow wrapWindow = new WrapWindow();
            wrapWindow.Show();
        }

        private void DockBtn_Click(object sender, RoutedEventArgs e)
        {
            DockWindow dockWindow = new DockWindow();
            dockWindow.Show();
        }

        
    }
}