using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Завдання_2
{
    delegate int Hours(int hours);
    delegate int Minutes(int minutes);
    delegate int Seconds(int seconds);
        
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("00:00:00");
            Timer timer = new Timer(3, 5, 4);
            timer.Start();
            Console.WriteLine("------------------");
            Console.WriteLine(timer);
            Console.ReadKey();
        }
    }

       
    class Timer
    {
        private int hours { get; set; }
        private int minutes { get; set; }
        private int seconds { get; set; }

        public Timer() { }

        public Timer(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        private int k = 1;

        public void Start()
        {
            Hours hours = Hour_s;
            Minutes minutes = Minute_s;
            Seconds seconds = Second_s;
            
            while (k <= 5)
            {
                Thread.Sleep(1000);                
                this.hours += hours(this.hours);
                this.minutes += minutes(this.minutes);
                this.seconds += seconds(this.seconds);
                Console.WriteLine("-------------");
                k++;
            }
        }

        public int Hour_s(int hours)
        {
            Console.WriteLine("{0} - години", hours);
            return hours * k;
        }

        public int Minute_s(int minutes)
        {
            Console.WriteLine("{0} - хвилини", minutes);
            return minutes * k;
        }

        public int Second_s(int seconds)
        {
            Console.WriteLine("{0} - секунди", seconds);
            return seconds * k;
        }

        override public String ToString()
        {
            return "Час: " + hours + ":" + minutes + ":" + seconds;
        }

    }
}

