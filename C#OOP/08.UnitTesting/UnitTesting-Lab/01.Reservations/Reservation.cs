using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Reservation
    {
        public DateTime startDate;
        public int days;
        public string customer;
        public Hotel? hotel;

        public Reservation()
        {
            startDate = DateTime.MinValue;
            days = 0;
            customer = "";
            hotel = null;
        }

        public Reservation(DateTime startDate_, int days_, string customer_, Hotel hotel_)
        {
            startDate = startDate_;
            days = days_;
            customer = customer_;
            hotel = hotel_;
        }
    }
}
