using System;
using System.Collections.Generic;
using System.Text;

namespace CheckClock
{
    class Prince
    {
        public  event PrinceChangEventHandle PrinceChange;
        public delegate void PrinceChangEventHandle(decimal oldchange, decimal newchange);
        decimal Prince_1 = 11000;
        public decimal Price_Men
        {
            set
            {
                if (Prince_1 == value) return;
                var olChanger = value;
                Prince_1 = value;
                PrinceChange?.Invoke(olChanger, Prince_1);
            }
            get => Prince_1;
        }
       
    }
    class Event_Test
    {
        public static void PrinceChange_Aument(decimal oldchange, decimal newchange)
        {
            Console.WriteLine($"Gia xang tang {newchange }");
        }
        public static void Prince_Abatement(decimal oldchange, decimal newchange)
        {
            Console.WriteLine($"Gia xang giam {oldchange - newchange}");
        }
        //public static void Main(string[] args)
        //{
        //    var prince = new Prince();
        //    prince.PrinceChange += PrinceChange_Aument;
        //    prince.Price_Men = 20000;
        //}
    }
}
