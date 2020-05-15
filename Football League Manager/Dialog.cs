using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_League_Manager
{
    static class Dialog
    {
        static private bool _isDisplaying = false;
        static private List<Timer> timerList = new List<Timer>();

        public static void Show(string body, string caption, MessageBoxButtons boxButtons, MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(body, caption, boxButtons, messageBoxIcon);
        }

        public static void Status(string message, Label statusText)
        {
            if (_isDisplaying)
            {
                foreach (var timer in timerList)
                {
                    timer.Stop();
                }
            }
            
            if (!_isDisplaying)
                statusText.Show();

            statusText.Text = message;

            _isDisplaying = true;

            HideMessage(statusText);
        }

        private static void HideMessage(Label statusText)
        {
            var t = new Timer();
            t.Interval = 2000;

            timerList.Add(t);

            // after 2 seconds, hide the status label
            t.Tick += (s, e) =>
            {
                statusText.Hide();
                _isDisplaying = false;
                t.Stop();
            };

            t.Start();
        }
    }
}
