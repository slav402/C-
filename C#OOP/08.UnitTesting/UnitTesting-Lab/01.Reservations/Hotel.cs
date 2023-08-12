using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Hotel
    {
        private int id;
        private string name;

        static public Dictionary<int, Hotel> hotels = new Dictionary<int, Hotel>();


        public Hotel(int id_, string name_)
        {
            id = id_;
            name = name_;
        }

        static public Hotel CreateHotel(int id_, string name_)
        {
            if (hotels.ContainsKey(id_))
            {
                throw new InvalidDataException("Hotel already exist!");
            }

            Hotel hotel = new Hotel(id_, name_);
            
            hotels[hotel.GetId()] = hotel;

            return hotel;
        }

        static public bool DeleteHotel(int id_)
        {
            return Hotel.hotels.Remove(id_);
        }

        public string GetName() => name;
        public int GetId() => id;
    }
}