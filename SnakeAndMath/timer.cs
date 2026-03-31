using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SnakeAndMath
{
    internal class PlayerTimer
    {
        private Timer timer;
        public int TimeLeft { get; private set; }
        public bool IsRunning { get; private set; }
        public double Interval { get; set; } = 1000;

        public event Action TimeUp;
        public event Action<int> TimeChanged;

        public PlayerTimer()
        {
            Interval = 1000;
            IsRunning = false;
        }

        public void Start(int seconds)
        {
            timer?.Stop();

            TimeLeft = seconds;
            IsRunning = true;

            timer = new Timer(Interval);
            timer.Elapsed += OnTimeTick;
            timer.Start();
        }

        private void OnTimeTick(object sender, ElapsedEventArgs e)
        {
            TimeLeft--;

            TimeChanged?.Invoke(TimeLeft);

            if (TimeLeft <= 0)
            {
                timer.Stop();
                IsRunning = false;
                TimeUp?.Invoke();
            }
        }

        public void Stop()
        {
            timer?.Stop();
            IsRunning = false;
        }
    }
}


