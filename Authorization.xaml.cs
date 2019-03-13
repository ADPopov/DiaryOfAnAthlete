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

namespace DiaryOfAnAthlete.Sections
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void IsClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SignInBtn(object sender, RoutedEventArgs e)
        {
            if (InputPassword.Password == "admin" && LoginInput.Text == "AlexPopov")
            {
                Window mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                WrongInputText.Text = "Неверный логин или пароль";
            }
        }
    }
}
