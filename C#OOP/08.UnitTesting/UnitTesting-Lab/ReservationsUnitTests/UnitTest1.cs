using Reservations;

namespace ReservationsUnitTests
{
    public class HotelTests
    {
        int hotelsAtEntry;
        Hotel? hotel;
        int testHotelId = 5;
        string testHotelName = "Trimontium";

        [OneTimeSetUp]
        public void oneTimeSetUp()
        {
            hotelsAtEntry = Hotel.hotels.Count;

            Assert.IsFalse(Hotel.hotels.ContainsKey(testHotelId), "Hotel already exist, test cannot continue!");

            hotel = Hotel.CreateHotel(testHotelId, testHotelName);
        }

        [OneTimeTearDown]
        public void oneTimeTearDown()
        {
            Hotel.DeleteHotel(testHotelId);

            Assert.AreEqual(hotelsAtEntry, Hotel.hotels.Count, "Incorrect delete hotel!");
        }

        
        [Test]
        public void Test1_CreateHotelCreatesOnlyOneHotel()
        {
            //Assert.Pass();

            Assert.AreEqual(Hotel.hotels.Count, hotelsAtEntry + 1, "Hotels are not empty on startup!");    // стария запис

            //Assert.That(currentHotelsCount+1, Is.EqualTo(Hotel.hotels.Count), "Hotels are not empty on startup!");    // новия запис
        }
    }
}