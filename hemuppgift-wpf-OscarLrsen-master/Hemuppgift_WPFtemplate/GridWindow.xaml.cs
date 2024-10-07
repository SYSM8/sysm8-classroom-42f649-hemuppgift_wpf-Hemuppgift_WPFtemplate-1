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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {

        private Random random;
        public GridWindow()
        {
            InitializeComponent();
            random = new Random();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int row, column;

            if (int.TryParse(RowInput.Text, out row) && int.TryParse(ColumnInput.Text, out column))
            {
                if (row >= 0 && row <= 3 && column >= 0 && column <= 3)
                {
                    Markerare.SetValue(Grid.RowProperty, row + 1); //Plus 1 för första raden tillhör inmatningsraden.
                    Markerare.SetValue(Grid.ColumnProperty, column);
                    Markerare.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Skriv värden mellan 0 och 3 för både rad och kolumn.");

                }

            }
        }

        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {
            int randomRow = random.Next(0, 3);
            int randomColumn = random.Next(0, 3);

            ShufflePicker(randomRow, randomColumn);
        }
        private void ShufflePicker(int row, int column)
        {
            Shuffler.SetValue(Grid.RowProperty, row + 1); // +1 eftersom första raden är för inmatningen
            Shuffler.SetValue(Grid.ColumnProperty, column);
            Shuffler.Visibility = Visibility.Visible;

        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
