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

namespace TimerApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer;
        public MainWindow()
        {
            InitializeComponent();

            this.WindowState= WindowState.Minimized;
            timer = new Timer(30, 0, 0);
            timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.SetTime(Convert.ToInt32(txbMinute.Text));
        }
    }
}
