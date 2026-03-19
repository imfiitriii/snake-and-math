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
        private int timeLeft;

        public event Action TimeUp;
        public event Action<int> TimeChanged;

        public void Start(int seconds)
        {
            timeLeft = seconds;
            timer = new Timer(1000);
            timer.Elapsed += OnTimeTick;
            timer.Start();
        }

        private void OnTimeTick(object sender, ElapsedEventArgs e)
        {
            timeLeft--;
            TimeChanged?.Invoke(timeLeft);

            if (timeLeft <= 0)
            {
                timer.Stop();
                TimeUp?.Invoke();
            }
        }

        public void Stop()
        {
            timer?.Stop();
        }
    }
}
