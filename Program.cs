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
            int speedCmd = 500;
            string LED = null;
            string command = null;
            Boolean loopContinue = true;
            Console.WriteLine($@"=============***>>>>>>>                            <<<<<<<<<<<******==========
                    Welcome to the Chenillard console ");
            Chenillard chenillardContol = new Chenillard();

            while (true && loopContinue== true)
            {
                Console.WriteLine("Start the chenillard by pressing [V], stop chenillard with [C], select your speed with [S]. To quit, press [Q]. To change Order, press [O]. Actual speed : " + chenillardContol.speed + "ms");
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
                    case "O":
                        Console.WriteLine("Choose Order :");
                        Console.WriteLine("LED1 :");
                        LED = Console.ReadLine();
                        chenillardContol.Led1 = LED;
                        Console.WriteLine("LED2 :");
                        LED = Console.ReadLine();
                        chenillardContol.Led2 = LED;
                        Console.WriteLine("LED3 :");
                        LED = Console.ReadLine();
                        chenillardContol.Led3 = LED;
                        Console.WriteLine("LED4 :");
                        LED = Console.ReadLine();
                        chenillardContol.Led4 = LED;

                        chenillardContol.changeOrder();
                        break;

                    case "Q":
                        Console.WriteLine("Exiting..");
                        loopContinue = false;
                        break;
                }


            }

            Console.WriteLine("End... ");
            Console.ReadLine();
        }

    }
}
