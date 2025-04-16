using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class PropertySeed
    {
        public static List<Property> Data => new()
        {
            new Property
            {
                Id = "cc4e48ea-ca54-4d32-a448-3c2c9d14f936",
                Title = "Entire rental unit in Nazlet El-Semman, Egypt",
                Description = "Enjoy your stay with Panoramic View of the giza pyramids and sphinx .Yes! view and pictures are all 100% real...",
                PricePerNight = 3000,
                LocationId = 1,
                Latitude = 29.98333M,
                Longitude = 31.13333M,
                SafteyInfo = "No Carbon monoxide alarm , No Smoke alarm ",
                HouseRules = "Check-in after 2:00 PM , Checkout before 11:00 AM , 2 guests maximum",
                CancellationPolicy = "Free cancellation before May 28 , Cancel before check-in on Jun 2 for a partial refund.",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 1
            },
            new Property
            {
                Id = "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4",
                Title = "Milano Duomo center 10 min Flat inside a castle",
                Description = "Elegant apartment inside the famous castle in Nolo, a royal choice right in the center of Milan...",
                PricePerNight = 5000,
                LocationId = 2,
                Latitude = 45.46427M,
                Longitude = 9.18951M,
                SafteyInfo = "Carbon monoxide alarm ,Smoke alarm installed",
                HouseRules = "Check-in: 3:00 PM - 11:00PM ,Checkout before 11:00 AM ,4 guests maximum",
                CancellationPolicy = "Free cancellation before May 17 , Cancel before check-in on May 18 for a partial refund.",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 2
            },
            new Property
            {
                Id = "3e7f99ab-228a-4d90-91c4-6adf8c12e048",
                Title = "Rent an apartment near Alhar Mecca",
                Description = "Relax with this listing Small 2-room 7-bed apartment near Alharam Al Makkah with a maximum of 10 to 12 minutes' walk away...",
                PricePerNight = 6000,
                LocationId = 3,
                Latitude = 21.4266M,
                Longitude = 39.8256M,
                SafteyInfo = "Carbon monoxide alarm ,Smoke alarm installed",
                HouseRules = "Check-in after 3:00 PM , Checkout before 12:00 PM , 7 guests maximum",
                CancellationPolicy = "Free cancellation before May 17 , Cancel before check-in on May 18 for a partial refund.",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 3
            },
            new Property
            {
                Id = "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa",
                Title = "Hawkeye Dome - New Pool and Spa",
                Description = "Updated pool and spa! Sitting on 100 acres, Hawkeye House, featured on the cover of the May 2019 issue of Dwell Magazine...",
                PricePerNight = 15000,
                LocationId = 4,
                Latitude = 34.114174M,
                Longitude = -116.432236M,
                SafteyInfo = "Carbon monoxide alarm ,Smoke alarm installed",
                HouseRules = "Check-in after 3:00 PM , Checkout before 12:00 PM , 7 guests maximum",
                CancellationPolicy = "Free cancellation before May 17 , Cancel before check-in on May 18 for a partial refund.",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 1
            },
            new Property
            {
                Id = "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2",
                Title = "(4 charming oceanfront loft!",
                Description = "Romantic Loft with mezzanine and large balcony in front of the sea, double bed and 1 single bed, tv, wi-fi, fan...",
                PricePerNight = 1300,
                LocationId = 5,
                Latitude = -12.9711M,
                Longitude = -38.5108M,
                SafteyInfo = "Carbon monoxide alarm not reported , Smoke alarm not reported , Exterior security cameras on property",
                HouseRules = "3 guests maximum , Pets allowed",
                CancellationPolicy = "Free cancellation before Oct 22 , Cancel before check-in on Oct 23 for a partial refund.",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 2
            },
            new Property
            {
                Id = "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3",
                Title = "Sunny and cozy Apartment Sagrada Familia",
                Description = "Set in an architectural prize-winning building, this modern Barcelona apartment beauty has impressive detail...",
                PricePerNight = 6500,
                LocationId = 6,
                Latitude = 41.3888M,
                Longitude = 2.159M,
                SafteyInfo = "No carbon monoxide alarm , No smoke alarm , Heights without rails or protectio",
                HouseRules = "Check-in: 3:00 PM - 5:00 PM ,Checkout before 10:00 AM ,2 guests maximum",
                CancellationPolicy = "Free cancellation before Jun 3. Cancel before check-in on Jun 4 for a partial refund",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 2
            },
            new Property
            {
                Id = "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7",
                Title = "Wadi Rum Sunset Cave",
                Description = "To give you the best experience of the authentic Bedouin life style, we will gather around the fire...",
                PricePerNight = 2200,
                LocationId = 7,
                Latitude = 29.5726M,
                Longitude = 35.4186M,
                SafteyInfo = "No carbon monoxide alarm , No smoke alarm , Heights without rails or protectio",
                HouseRules = "Check-in: 3:00 PM - 5:00 PM ,Checkout before 10:00 AM ,2 guests maximum",
                CancellationPolicy = "Free cancellation before Jun 3. Cancel before check-in on Jun 4 for a partial refund",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 4
            },
            new Property
            {
                Id = "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f",
                Title = "New! The View: See to Mouintain (with pool)",
                Description = "Interior designer's own guesthouse, this unique place has a style all its own...",
                PricePerNight = 9000,
                LocationId = 8,
                Latitude = 43.5914M,
                Longitude = 6.8761M,
                SafteyInfo = "No carbon monoxide alarm , No smoke alarm , Heights without rails or protectio",
                HouseRules = "Check-in: 3:00 PM - 5:00 PM ,Checkout before 10:00 AM ,2 guests maximum",
                CancellationPolicy = "Free cancellation before Jun 3. Cancel before check-in on Jun 4 for a partial refund",
                OwnerId = "3dacdb51-fee9-4479-904c-cafe7dca22a7",
                PropertyTypeId = 1
            }
        };

    }
}
