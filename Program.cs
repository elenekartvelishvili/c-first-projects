using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Classes;
using ConsoleApp1.Enums;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Courier courier1 = new Courier("Nika", AreaEnum.Vake, 100);
                Courier courier2 = new Courier("Nika", AreaEnum.Saburtalo, 150);
                Courier courier3 = new Courier("Nika", AreaEnum.MtaTsminda, 50);
                Courier courier4 = new Courier("Nika", AreaEnum.Vera, 20);

                courier1.DistributeOrders(5, 90);
                courier1.DistributeOrders(3, 10);
                courier1.DistributeOrders(2, 10);
                Console.WriteLine(courier1);
                courier2.DistributeOrders(10, 115);
                Console.WriteLine(courier2);
                courier3.DistributeOrders(14, 15);
                Console.WriteLine(courier3);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }


        }
    }
}
