using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ChenillardConsole.ChenillardController;
namespace ChenillardConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chenillard Console 
            int counter = 0;
            int speedCmd = 500;
            string command = null;
            Boolean loopContinue = true;
            Console.WriteLine($@"=============***>>>>>>>                            <<<<<<<<<<<******==========
                    Welcome to the Chenillard console ");
            Chenillard chenillardContol = new Chenillard();

            while (true && loopContinue== true)
            {
                Console.WriteLine("Start the chenillard by pressing [V], stop chenillard with [C], select your speed with [S]. To quit, press [Q]. Actual speed : " + chenillardContol.speed + "ms");
                command = Console.ReadLine();
                switch (command)
                {
                    case "V":
                        chenillardContol.startChenillard();
                        break;
                    case "C":
                        chenillardContol.stopChenillard();
                        break;
                    case "S":
                        Console.WriteLine("Choose your Speed : ");
                        speedCmd = Convert.ToInt32(Console.ReadLine());
                        chenillardContol.speed = speedCmd;
                        break;
                    case "Q":
                        Console.WriteLine("Exiting..");
                        loopContinue = false;
                        break;
                }


                //Console.WriteLine("Start Chenillard");

                //chenillardContol.startChenillard();
            }

            Console.WriteLine("End... ");
            Console.ReadLine();
        }

    }
}
