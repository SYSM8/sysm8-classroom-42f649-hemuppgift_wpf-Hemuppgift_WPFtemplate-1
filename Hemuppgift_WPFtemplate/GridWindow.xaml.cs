using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        public GridWindow()
        {
            InitializeComponent();
            
        }

        private void AddButtonToGrid(int row, int column)
        {
            Button gridButton = new Button 
            {
                Content = $"Row {row}, Column {column}",
                Background = Brushes.LightGreen,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Width = 200, Height = 100,

            };
            Grid.SetRow(gridButton, row);
            Grid.SetColumn(gridButton, column);
            MyGrid.Children.Add(gridButton);

        }


        private void AddBtn_Click_1(object sender, RoutedEventArgs e)
        {
            int row;
            int column;
            if (Int32.TryParse(RowBox.Text, out row) && Int32.TryParse(ColumnBox.Text, out column))
            {
                if (row >= 0 && row <= 3 && column >= 0 && column <= 3)
                {
                    AddButtonToGrid(row, column);

                }

                else
                {
                    MessageBox.Show("Vänligen skriv siffror");

                }
            }
        }
    }   

    

        

        




    
}

