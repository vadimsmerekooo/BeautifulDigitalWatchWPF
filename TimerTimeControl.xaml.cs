﻿using System;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для TimerTimeControl.xaml
    /// </summary>
    public partial class TimerTimeControl : UserControl
    {
        public TimerTimeControl()
        {
            InitializeComponent();
            SetTimeNumber();
            DispatcherTimer timerDots = new DispatcherTimer();
            timerDots.Tick += new EventHandler(MethodAnimation);
            timerDots.Interval = new TimeSpan(0, 0, 1);
            timerDots.Start();
        }
        private void MethodAnimation(object sender, EventArgs e)
        {
            SetTimeNumber();
            ((Storyboard)FindResource("TickDots")).Begin();
        }
        public void SetTimeNumber()
        {
            DateTime mainDateTime = DateTime.Now;
            Day.Text = mainDateTime.DayOfWeek.ToString();
            DayNumeric.Text = "Day " + mainDateTime.Date.ToString().Split(' ')[0];
            if ((mainDateTime.TimeOfDay.Hours.ToString().ToCharArray()).Length == 2)
            {
                Hours1.Text = mainDateTime.TimeOfDay.Hours.ToString().ToCharArray()[0].ToString();
                Hours2.Text = mainDateTime.TimeOfDay.Hours.ToString().ToCharArray()[1].ToString();
            }
            else
            {
                Hours1.Text = 0.ToString();
                Hours2.Text = mainDateTime.TimeOfDay.Hours.ToString().ToCharArray()[0].ToString();
            }
            // Minutes Minutes Minutes Minutes Minutes Minutes Minutes Minutes Minutes Minutes
            if ((mainDateTime.TimeOfDay.Minutes.ToString().ToCharArray()).Length == 2)
            {
                Minutes1.Text = mainDateTime.TimeOfDay.Minutes.ToString().ToCharArray()[0].ToString();
                Minutes2.Text = mainDateTime.TimeOfDay.Minutes.ToString().ToCharArray()[1].ToString();
            }
            else
            {
                Minutes1.Text = 0.ToString();
                Minutes2.Text = mainDateTime.TimeOfDay.Minutes.ToString().ToCharArray()[0].ToString();
            }
            // SECONDS SECONDS SECONDS SECONDS SECONDS SECONDS SECONDS SECONDS SECONDS SECONDS
            if ((mainDateTime.TimeOfDay.Seconds.ToString().ToCharArray()).Length == 2)
            {
                Seconds1.Text = mainDateTime.TimeOfDay.Seconds.ToString().ToCharArray()[0].ToString();
                Seconds2.Text = mainDateTime.TimeOfDay.Seconds.ToString().ToCharArray()[1].ToString();
            }
            else
            {
                Seconds1.Text = 0.ToString();
                Seconds2.Text = mainDateTime.TimeOfDay.Seconds.ToString().ToCharArray()[0].ToString();
            }
        }
    }
}
