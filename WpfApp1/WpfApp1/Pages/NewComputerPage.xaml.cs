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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Model;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewComputerPage.xaml
    /// </summary>
    public partial class NewComputerPage : Page
    {
        public NewComputerPage()
        {
            InitializeComponent();
        }

        private void BAddComputer_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Computers testXammatovEntities = new App.DB(testXammatovEntities);

        }
    }
}
