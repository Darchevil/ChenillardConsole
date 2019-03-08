using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChenillardConsole.ChenillardController
{
    class Chenillard
    {

        private Boolean ActiveChen;
        public int speed;
        public string Led1 = "1";
        public string Led2 = "2";
        public string Led3 = "3";
        public string Led4 = "4";
        string[] arrayLed;
        public Chenillard()
        {
            this.ActiveChen = false;
            this.speed = 500;
            arrayLed = new string[] { Led1, Led2, Led3, Led4 };
        }

        public void startChenillard()
        {
            ThreadStart threadStart = new ThreadStart(GoChenillard);
            Thread threadChen = new Thread(threadStart);
            ActiveChen = true;

            threadChen.Start();
        }

        public void GoChenillard()
        {
            int i = 0;
            while (ActiveChen == true)
            {
                if (i == 4)
                {
                    i = 0;
                }
                Console.WriteLine(arrayLed[i]);
                Thread.Sleep(this.speed);
                Console.WriteLine("(.)");
                
                i++;
                
                //Console.WriteLine(arrayLed[i+1]);
                //Thread.Sleep(this.speed);
                //Console.WriteLine("(.)");
                //Console.WriteLine(arrayLed[i]);
                //Thread.Sleep(this.speed);
                //Console.WriteLine("(.)");
                //Console.WriteLine(arrayLed[i]);
                //Thread.Sleep(this.speed);
                //Console.WriteLine("(.)");
            }
        }

        public void stopChenillard()
        {
            this.ActiveChen = false;
        }
        public void changeOrder()
        {
            this.arrayLed = new string[] {Led1,Led2,Led3,Led4};

        }
    }
}
