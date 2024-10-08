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
    /// Interaction logic for DPWindow.xaml
    /// </summary>
    public partial class DPWindow : Window
    {
        public DPWindow()
        {
            InitializeComponent();
        }


        private void MainMenuBtn(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        private void Center_Click(object sender, RoutedEventArgs e)
        {
            TrophyPage trophypage = new TrophyPage();
            trophypage.Show();
            this.Close();

        }
    }
}
