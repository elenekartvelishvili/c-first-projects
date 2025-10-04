using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Courier
    {
        public string Name { get; set; }
        public AreaEnum AreaEnum { get; set; }
        public int Limit { get; set; }
        public int CurrentLoad { get; set; }
        public Dictionary<int, int> bookings = new Dictionary<int, int>();

        public Courier(string Name, AreaEnum areaenum, int limit)
        {
            this.Name = Name;
            this.AreaEnum = areaenum;
            this.Limit = limit;
        }
      


        public bool IsBusy()
        {
            if (CurrentLoad < Limit)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
        public float LoadInPercent
        {
            get
            {
                return ((float)CurrentLoad / Limit) * 100;
            }
        }

        public static bool operator ==(Courier courier, Courier other)
        {
            return courier.AreaEnum.Equals(other);
        }
        public static bool operator !=(Courier courier, Courier other)
        {
            return !(courier.AreaEnum == other.AreaEnum);
        }
        public static bool operator >=(Courier courier, Courier other)
        {
            return courier.LoadInPercent > other.LoadInPercent;
        }
        public static bool operator <=(Courier courier, Courier other)
        {
            return courier.LoadInPercent < other.LoadInPercent;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            string status = IsBusy() ? "Busy" : "Free";
            return $"Courier's name:{Name},\n" +
                $" Limit:{Limit},\n" +
                $"current load:{LoadInPercent}%,\n" +
                $" status:{status}";
        }
        public int DistributeOrders(int orderId, int demand)
        {
          
            
                if (CurrentLoad + demand <= Limit) 
                {
                    CurrentLoad += demand;
                    bookings.Add(orderId, CurrentLoad);
                    Console.WriteLine($"order {orderId} has been picked up by {Name}");
                    return CurrentLoad;
                }
                else
                {
                if (IsBusy())
                {
                    Console.WriteLine($"{Name} is busy at the moment,so they are not able to pick up your order");
                    return 0;
                }
            }

                return CurrentLoad;
            }
       
        }

        }
    


