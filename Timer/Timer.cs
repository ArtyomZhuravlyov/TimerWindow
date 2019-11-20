using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TimerApp
{
    class Timer
    {
        private DispatcherTimer TimerDisp = new DispatcherTimer();
        private WinTimer winTimer ;


       public  Timer(int minute=20, int hour =0, int sec = 0)
        {
            SetTime(minute, hour, sec);
            TimerDisp.Tick += Timer_Tick;  
        }

        public void SetTime(int minute = 20, int hour = 0, int sec = 0)
        {
            TimerDisp.Interval = new TimeSpan(hour, minute, sec);
        }

        private void Timer_Tick(object sender, object e)
        {
           
            if (winTimer==null || !winTimer.IsVisible )
                winTimer = new WinTimer(); 
            winTimer.Show();
        }

        public void Start()
        {
            TimerDisp.Start();
        }
    }
}
