using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingLogger
{
    class PingClass
    {

        bool Pinging;
        static System.Windows.Forms.Timer MyTime = new System.Windows.Forms.Timer();
        public Form1 f1;
        Ping p = new Ping();
        PingReply pr;



        public void InitializeTimer()
        {
            /* Adds the event and the event handler for the method that will 
               process the timer event to the timer. */
            MyTime.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 1 seconds.
            MyTime.Interval = 1000;
            MyTime.Start();

            Application.DoEvents();
        }

        public void Start()
        {
            Pinging = false;
            Debug.WriteLine("Bool Pinging: " + Pinging);
        }

        public void EnablePing()
        {
            if (Pinging)
            {
                f1.Controls["StartPingBtn"].Text = "Start Ping";
                Pinging = false;
            }
            else if (!Pinging)
            {
                f1.Controls["StartPingBtn"].Text = "Stop Ping";
                
                Pinging = true;
            }
        }

        void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            //Debug.WriteLine("Timer Tick " + DateTime.Now);

            ActualPing();
        }

        void ActualPing()
        {
            if (Pinging)
            {
                pr = p.Send(f1.Controls["ipAdressBox"].Text);
                //f1.Controls["OutputText"].Text += "Timer Tick " + DateTime.Now + Environment.NewLine;
                //f1.Controls["OutputText"].Text += new Ping().Send("www.google.com").RoundtripTime.ToString() + "ms" + Environment.NewLine;
                f1.Controls["OutputText"].Text += "bytes="+pr.Buffer.Length.ToString() + " " + pr.RoundtripTime.ToString()+"ms" + " " + pr.Status.ToString() + Environment.NewLine;
            }
        }

    }
}
