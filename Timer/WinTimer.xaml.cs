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

namespace TimerApp
{
    /// <summary>
    /// Логика взаимодействия для WinTimer.xaml
    /// </summary>
    public partial class WinTimer : Window
    {
        public WinTimer()
        {
            InitializeComponent();
            this.Topmost = true;
            var primaryMonitorArea = SystemParameters.WorkArea;
            Left = primaryMonitorArea.Right - Width;// - 10;
            Top = primaryMonitorArea.Bottom - Height;// - 10;
            this.Closed += new EventHandler(ClosedWinTimer);
        }

        private void ClosedWinTimer (object sender, System.EventArgs e)
        {
            
        }

    }
}
