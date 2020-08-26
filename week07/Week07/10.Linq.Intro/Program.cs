using System;

namespace _10.Linq.Intro
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<Hotel> hotels = CreateHotelList();

            // V1
            IEnumerable<Hotel> hotelsWithMoreThan100RoomsV1 = 
                from hotel in hotels 
                where hotel.NumberOfRooms > 100 
                select hotel;

            foreach (var hotel in hotelsWithMoreThan100RoomsV1)
            {
                Console.WriteLine(hotel.Name);
            }

            // V2
            IEnumerable<Hotel> hotelsWithMoreThan100RoomsV2 =
                hotels.Where(hotel => hotel.NumberOfRooms > 100);

            foreach (var hotel in hotelsWithMoreThan100RoomsV2)
            {
                Console.WriteLine(hotel.Name);
            }

            Hotel h = hotels.Where(h => h.Id == 2).FirstOrDefault();
            // first, return reference
            // default, default type (null, 0)

            // Manual
            //Func<Hotel, bool> checkHotel = CheckHotel;

            //IList<Hotel> hotelsTemp = new List<Hotel>();

            //foreach (var hotel in hotels)
            //{
            //    if (checkHotel(hotel))
            //    {
            //        hotelsTemp.Add(hotel);
            //    }
            //}
        }

        private static bool CheckHotel(Hotel hotel)
        {
            if (hotel.NumberOfRooms > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<Hotel> CreateHotelList()
        {
            List<Hotel> hotels = new List<Hotel>();

            hotels.Add(new Hotel { Id = 1, City = "IS", Name = "Hotel 1", NumberOfRooms = 100 });
            hotels.Add(new Hotel { Id = 2, City = "IS", Name = "Hotel 2", NumberOfRooms = 120 });
            hotels.Add(new Hotel { Id = 3, City = "IS", Name = "Hotel 3", NumberOfRooms = 10 });
            hotels.Add(new Hotel { Id = 4, City = "IS", Name = "Hotel 4", NumberOfRooms = 62 });
            hotels.Add(new Hotel { Id = 5, City = "IS", Name = "Hotel 5", NumberOfRooms = 120 });
            hotels.Add(new Hotel { Id = 6, City = "SV", Name = "Hotel 6", NumberOfRooms = 10 });
            hotels.Add(new Hotel { Id = 7, City = "SV", Name = "Hotel 7", NumberOfRooms = 300 });
            hotels.Add(new Hotel { Id = 8, City = "SV", Name = "Hotel 8", NumberOfRooms = 100 });
            hotels.Add(new Hotel { Id = 9, City = "SV", Name = "Hotel 9", NumberOfRooms = 600 });

            return hotels;
        }
    }

    public class Hotel
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Name { get; set; }

        public int NumberOfRooms { get; set; }
    }
}
