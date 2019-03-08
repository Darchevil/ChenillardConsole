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
        
        public Chenillard()
        {
            this.ActiveChen = false;
            this.speed = 500;
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
            while (ActiveChen == true)
            {
                Console.WriteLine("(1)");
                Thread.Sleep(this.speed);
                Console.WriteLine("(.)");
                Console.WriteLine("(2)");
                Thread.Sleep(this.speed);
                Console.WriteLine("(.)");
                Console.WriteLine("(3)");
                Thread.Sleep(this.speed);
                Console.WriteLine("(.)");
                Console.WriteLine("(4)");
                Thread.Sleep(this.speed);
                Console.WriteLine("(.)");
            }
        }

        public void stopChenillard()
        {
            this.ActiveChen = false;
        }
    }
}
