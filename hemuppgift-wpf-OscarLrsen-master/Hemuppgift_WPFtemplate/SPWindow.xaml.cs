﻿using System;
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
    /// Interaction logic for SPWindow.xaml
    /// </summary>
    public partial class SPWindow : Window
    {
        public SPWindow()
        {
            InitializeComponent();
        }

        private void HorizontalBtn(object sender, RoutedEventArgs e)
        {
            FyrkantigSP.Orientation = Orientation.Horizontal;
        }

        private void VerticalBtn(object sender, RoutedEventArgs e)
        {
            FyrkantigSP.Orientation = Orientation.Vertical;
        }

        private void MainMenuBtn(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
