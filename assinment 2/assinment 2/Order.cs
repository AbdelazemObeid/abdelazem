using System;
using System.Collections.Generic;
using System.Text;

namespace assinment_2
{
    public class Order
    {
        public int ID;
        public string Name;
        public int Totalprice;
        public DateTime date;
        public bool IsDelivered;
        public Order(int id, string name, int totalprice, DateTime date, bool isdelivered)
        {
            ID = id;
            Name = name;
            Totalprice = totalprice;
            this.date = date;
            IsDelivered = isdelivered;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Total Price: {Totalprice}, Date: {date.ToShortDateString()}, Is Delivered: {IsDelivered}";
        }
    }
}
