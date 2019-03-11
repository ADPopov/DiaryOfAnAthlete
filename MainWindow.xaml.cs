using DiaryOfAnAthlete.Sections;
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

namespace DiaryOfAnAthlete
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnProgress(object sender, RoutedEventArgs e)
        {
            Main.Content = new Progress();
        }

        private void BtnPurpose(object sender, RoutedEventArgs e)
        {
            Main.Content = new Purpose();
        }

        private void BtnRecommendations(object sender, RoutedEventArgs e)
        {
            Main.Content = new Recommendations();
        }

        private void BtnSchudule(object sender, RoutedEventArgs e)
        {
            Main.Content = new Schedule();
        }

        private void BtnTrainings(object sender, RoutedEventArgs e)
        {
            Main.Content = new Trainings();
        }
    }

}
