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

        public void BtnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridwindow = new GridWindow();
            gridwindow.Show();
            this.Close();

            
        }

        private void BtnStock_Click(object sender, RoutedEventArgs e)
        {
            SPWindow spwindow = new SPWindow();
            spwindow.Show();
            this.Close();
        }

        private void BtnWrap_Click(object sender, RoutedEventArgs e)
        {
            WPWindow wpwindow = new WPWindow();
            wpwindow.Show();
            this.Close();
        }

        private void BtnDock_Click(object sender, RoutedEventArgs e)
        {
            DPWindow dpwindow = new DPWindow();
            dpwindow.Show();
            this.Close();
        }
    }
}