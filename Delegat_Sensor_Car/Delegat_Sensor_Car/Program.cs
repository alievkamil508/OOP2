using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Sensor_Car
{
    delegate void MyEvent();

    class Sob
    {
        public event MyEvent Event;


        public int temperature;
        public int oborot;

        public Sob(int value)
        {
            temperature = 45;
            oborot = value;
        }

        public void Oborot_Temperature()
        {
            if (temperature >= 45)
            {
                if (oborot < 2000)
                {
                    if (temperature > 45)
                    {
                        temperature -= 1;
                    }
                    else
                    {
                        temperature = 45;
                    }
                }
                else if (oborot >= 4000 && oborot <= 7000)
                {
                    temperature += 10;
                }
                else if (oborot >= 2000 && oborot < 4000)
                {
                    temperature += 5;
                }

                Console.WriteLine("Температура: " + temperature);

            }

        }

        public void Temperature()
        {
            Console.WriteLine("Есть угроза, температура выше нормы!!!  " + temperature);
        }


        public void OpasnoEvent()
        {
            if (temperature >= 90)
            {
                Event();
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            // оборот >= 2000
            Console.WriteLine("Введите оборот автомобиля: ");
            int val = int.Parse(Console.ReadLine());
            Sob evt = new Sob(val);

            evt.Event += evt.Temperature;

            for (int i = 0; i < 9; i++)
            {
                evt.Oborot_Temperature();

            }

            evt.OpasnoEvent();


            //оборот < 2000
            Console.WriteLine("Изменить оборот автомобиля: ");
            evt.oborot = int.Parse(Console.ReadLine());

            for (int i = 0; i < 7; i++)
            {
                evt.Oborot_Temperature();

            }

            evt.OpasnoEvent();



        }
    }
}
