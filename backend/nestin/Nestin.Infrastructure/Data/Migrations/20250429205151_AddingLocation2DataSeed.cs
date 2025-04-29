using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingLocation2DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 10, 114, "Soul ,South Korea  " });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "3e7f99ab-228a-4d90-91c4-6adf8c12e048",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Relax with this listing Small 2-room 7-bed apartment near Alharam Al Makkah with a maximum of 10 to 12 minutes' walk away The ears and prayer are also heard inside the rooms and the window appears from the window of the Haram Al-Sharif .We offer a Surface kitchen with tea and coffee supplies, a mini fridge, a microwave, a water kettle and more A washing machine is available and we provide toiletries from towels, shampoo, lotion, soap, and more We provide a wheelchair ,wi-fi .This place is in a high tower where the apartment is located on the 17th floor Wish you a unique and pleasant stay", 90m, 1 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId", "Title" },
                values: new object[] { "Romantic Loft with mezzanine and large balcony in front of the sea, double bed and 1 single bed, tv, wi-fi, fan, cabinet modern decoration, 180 degree terrace to the sea, equipped kitchen, bathroom, total comfort and privacy, fourth floor without elevator, 5 minutes from the carnival circuit, Noble Quarter of the city. Between the Surf and Paciencia beaches. Total security. The most beautiful sunset in Salvador", 130m, 1, "(4) charming oceanfront loft!" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Updated pool and spa! Sitting on 100 acres, Hawkeye House, featured on the cover of the May 2019 issue of Dwell Magazine, is an off grid Geodesic Dome. It has a 40 foot pool and hot tub that you will have to see to believe. This unique and modern home has been fully remodeled with an attention to both comfort and detail. Amazing hikes and privacy are abundant here. Most people never want to leave the property", 110m, 2 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Elegant apartment inside the famous castle in Nolo, a royal choice right in the center of Milan A few steps away is the metro (M1 red for the Duomo 10 min), 10 minutes' walk for the central station. The apartment is well connected by trains, trams and buses The area is well supplied with restaurants, supermarkets, bars, clubs, etc. Complete comfort:82 Smart TV, Netflix, prime, wifi, dishwasher, kitchen, coffee machine The stay is included with a complete reception service", 250m, 3 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Set in an architectural prize-winning building, this modern Barcelona apartment beauty has impressive detail throughout. Ceiling-to-floor sloped windows, wood floor, and other soft designer textures accentuate this spectacular space. It is cozy and welcoming but with a very hip, urban edge.Design enthusiasts and those looking for that modern Barcelona feel will love the apartment. However, high-comfort and proximity to the Sagrada Familia suits all tastes.", 310m, 1 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "cc4e48ea-ca54-4d32-a448-3c2c9d14f936",
                columns: new[] { "Description", "PricePerNight" },
                values: new object[] { "Enjoy your stay with Panoramic View of the giza pyramids and sphinx .Yes! view and pictures are all 100% real. (Be sure to check out our other listings too) Indulge in a stunning view of all the Giza Pyramids from anywhere within this contemporary oriental studio or while relaxing in the Jacuzzi. It is also a 10 min walk from the Pyramids entrance gate. To make the most of your trip, make sure to check out our experiences!We're committed to providing our guests the magical hospitality", 100m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f",
                columns: new[] { "Description", "PricePerNight" },
                values: new object[] { "Interior designer's own guesthouse, this unique place has a style all its own. Escape the ordinary and immerse yourself in comfort, calm and luxury at our charming bergerie, a conversion from a shepherd's old stone house! Nestled in the heart of the largest mimosa forest in Europe, overlooking the Cotes d'Azur and lower Alps, our tastefully designed retreat offers everything you need for an unforgettable tranquillity.We welcome up to 4 adults and have a small mezzanine for children.", 132m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "To give you the best experience of the authentic Bedouin life style, we will gather around the fire, cook our traditional food and tell you stories of our ancestors, while looking at the sky full of stars.Without a lie, this experience will be very special, if you used to cities and crowd in your everyday life.We created the space in a very simple, traditional and nomadic way. The Cave is inside the red rocks, waterproof and safe from all sides. Here you will have the whole Desert for yourself to get away from normal life, to relax, be in a quiet environment and meditate.", 220m, 1 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CancellationPolicy", "Description", "HouseRules", "IsActive", "Latitude", "LocationId", "Longitude", "OwnerId", "PricePerNight", "PropertyTypeId", "SafteyInfo", "Title" },
                values: new object[,]
                {
                    { "06dbae08-bc6b-4ca6-9162-3213784b9971", "Free cancellation before May 5. Cancel before check-in on May 9 for a full refund.", "Xoi Farmstay is located in a green valley of Lam Thuong in the North of Vietnam, about 250km from Hanoi and near to Hagiang and Sapa.This is a place for those who love nature, watching rice fields, exotic mountains, spring and waterfall, authentic local culture, good food, especially non touristy", "Check-in brfore 1:00 Am , Checkout before 11:00 AM , 1 guests maximum", true, 21.05m, 19, 105.4333m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 100m, 4, "carbon monoxide alarm  ,No Smoke alarm", "TXoi Farmstay- Homefarm in the valley of Lam Thuong" },
                    { "0bb50f31-e322-4b76-97dd-6a7fcf585d33", "Free cancellation before May 2, Cancel before check-in on May 3 for a partial refund.", "With panoramic water views, Delta Hotels by Marriott Virginia Beach Waterfront is an oasis on the shores of the breathtaking Chesapeake Bay.Thrill your palate with fresh oysters, fish, and coastal cuisine at our distinctive hotel restaurant, featuring inspiring water views.", "Check-in: 4:00 PM - 12:00 AM , Checkout before 11:00 AM ,4 guests maximum", true, 37.5407m, 14, 77.436m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 90m, 3, "Carbon monoxide alarm, Smoke alarm", "Escape To Our Beachfront Oasis | Private Beach" },
                    { "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08", "Free cancellation before May 26. Cancel before check-in on May 14 for a partial refund.", "Comfortable room, queen bed, bathroom in suite, with air conditioning. Excelent location, among Palermo and Recoleta neighborhoods, one block away from Santa Fe av and 2 blocks away from subway line D.", "Check-in brfore 4:00 Am , Checkout before 9:00 AM , 2 guests maximum", true, 34.6037m, 17, 58.3816m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 190m, 2, "No carbon monoxide alarm  ,No Smoke alarm", "Palermo/Recoleta. Stylish room w/ensuite-bath & AC" },
                    { "294e2751-203b-4beb-b21e-0bb96f082d7c", "Free cancellation before May 3. Cancel before check-in on May 14 for a full refund.", "Charming industrial character and premium homely comfort in the most desirable location. A leisurely stroll away from the shopping, dining & nightlife of Admiralty Way, Lekki Phase 1.Relax in the swimming pool or enjoy movies on satellite, Netflix or Amazon. Superfast optic-fibre broadband wi-fi. Uninterrupted 24/7 generator power back-up.", "Check-in brfore 2:00 Am , Checkout before 9:00 AM , 3 guests maximum", true, 6.4367m, 18, 3.5244m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 200m, 1, "carbon monoxide alarm  , Smoke alarm", "The Foundry. Luxury 2BR w/pool" },
                    { "2e3ed231-a2a6-4961-a1ba-f232d56c6f35", "Free cancellation before Apr 29. Cancel before check-in on May 1 for a partial refund.", "You will feel special from the beginning to the end of your holiday at Inone Mucho Selection Hotel, located on the seafront with a private beach in one of the clearest bays of Asarlik.Our facility which is located 5 minutes drive away from Bodrum center and 5 minutes from Gumbet bar street by walk. You can have a pleasant time while sipping your cocktail at our Iconic Beach restaurant, accompanied by various events and DJ performances.", "Check-in brfore 1:00 PM , Checkout before 10:00 PM , 2 guests maximum", true, 37.0383m, 25, 27.4292m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 200m, 2, "carbon monoxide alarm  ,  Smoke alarm", "Inone Mucho Selection Hotel Deluxe Room B&B" },
                    { "3c0e361a-51df-4e03-b8d0-2d7601aa60f6", "Free cancellation before Jun 18. Cancel before check-in on Jun 23 for a partial refund.", "Maadi is an uptown , green suburb with villas and gardens. My building is a five storey building . It is in a quiet area but a few minutes-walk away from Rd 9 where there are shops, cafes and restaurants. Everything you need is right here yet in 15 mins u can be in center of town.", "Flexible check-in , 2 guests maximum , No pets", true, 29.9617m, 12, 31.2667m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 100m, 2, "No carbon monoxide alarm , No smoke alarm ,Nearby lake, river, other body of water", "sunny, spacious, clean room in maadi, cairo.." },
                    { "4b04a76a-1608-4a8f-b09c-8d9043b83e16", "Free cancellation for 48 hours , Cancel before Jan 13 for a partial refund.", "Built in the 19th century, with a 360 degrees view over the sea and surroundings on the top floor.It features a Bedroom, a very well-decorated living room with kitchenette, and a WC.Free WiFi, air conditioning, Led TV and DVD player.Private parking inside the premises, providing extra security.Perfect for an unforgettable honeymoon experience.", "Check-in: 3:00 PM - 5:00 PM ,Checkout before 10:00 AM ,2 guests maximum", true, 37.7428m, 9, 25.6806m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 200m, 4, "Climbing or play structure , Carbon monoxide alarmSmoke alarm", "Moinho das Feteiras | The Mill House" },
                    { "52a8df7d-c0b2-4ee3-8369-9daed4885f9f", "Free cancellation before Apr 26. Cancel before check-in on May 1 for a partial refund.", "Chill in a quite and fresh area only 3 min drive to Ubud center.Our villa located in the middle of rice field , offered you great experience.Friendly owner will assist you 24 hours by call to make sure you can enjoy the stay .Stay for 3 nights and you will get Free Traditional Balinese massage for 1 person for 60 min to complete the lazy days", "Check-in brfore 3:00 PM , Checkout before 12:00 PM , 3 guests maximum", true, -8.5441m, 23, 115.3255m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 110m, 1, "carbon monoxide alarm  , No Smoke alarm , Nearby lake, river, other body of water", "Quite Get Away near by theCenter" },
                    { "763e6c5f-1ad1-4071-b0e6-55e924624198", "Free cancellation before May 5. Cancel before check-in on May 9 for a full refund.", "Dar Ouassaggou's owner, Houssine, is a fluent English speaker and looks forward to welcoming you to his friendly guesthouse retreat in the Atlas Mountains, A Warm Welcome Awaits you at Dar Ouassaggou.It is a small comfortable guest house with 13 en suite rooms and balcony .", "Check-in brfore 11:00 Am , Checkout before 12:00 AM , 3 guests maximum", true, 31.1333m, 21, 7.9167m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 220m, 2, "No carbon monoxide alarm  , Smoke alarm", "Atlas Mountains Riad Oussagou" },
                    { "a555515a-ff8a-4741-b0a4-db9be729198e", "Free cancellation before May 4. Cancel before check-in on May 5 for a partial refund.", "Discover this luxury apartment in Gammarth, in the tourist area, with sea views and direct access to a private beach reserved for residents. The master suite includes a private bathroom, and a second bathroom is available", "Check-in after 3:00 PM,4 guests maximum,Pets allowed", true, 36.9475m, 15, 10.3036m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 20m, 4, "Carbon monoxide alarm not reported , Smoke alarm not reported", "Sea View S2: Waterfront, Private Beach" },
                    { "c10d2d46-869a-46bc-a46d-90bdd958c252", "Free cancellation before May 9. Cancel before check-in on May 14 for a partial refund.", "Warm and cosy cottage decorated with antique furniture, with a lovely garden. Perfect if you're looking for a relaxing stay in beautiful countryside. The bedroom windows have blackout blinds and the beds are very comfortable.", "Check-in: (4:00 PM - 10:00 PM) , Checkout before 11:00 AM , 4 guests maximum", true, 50.7236m, 16, 4.8694m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 230m, 1, "No carbon monoxide alarm , Nearby lake- river- other body of water , Smoke alarm", "Cosy English cottage with beautiful garden" },
                    { "c150e428-1c9a-43a2-be07-f4366875f1ce", "Free cancellation before Apr 29. Cancel before check-in on May 1 for a partial refund.", "Elegant and spacious apartment on the 4th floor, designed and realized for 6 people.Totally renovated in February 2025.,Composed of 2 double bedrooms, 1 single bedroom and a sofa bed in the dining room.,2 bathrooms of which one inside the double room.It is possible to access the terrace from each room.", "Check-in brfore 1:00 PM , Checkout before 10:00 PM , 2 guests maximum", true, 41.9028m, 24, 12.4964m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 90m, 3, "carbon monoxide alarm  ,  Smoke alarm", "[*Bright new Metro C penthouse*]." },
                    { "c5c0d4db-b048-4ee4-8835-344900fd35b2", "Add your trip dates to get the cancellation details for this stay.", "Charming small cottage situated on the edge of wetlands with beautiful views. Private gazebo with covered firepit and a dock over looking the large pond. Located on our 5 acre free range egg farm in Merville, BC. The pond is home to a family of beavers, bald eagles, blue heron and various birds. Private walking trail off the cottage and access to the One Spot Trail at the end of our private drive.", "Check-in after 3:00 PM,Checkout before 11:00 AM,2 guests maximum", true, 49.6876m, 13, 124.9936m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 400m, 4, "Exterior security cameras on property ,Carbon monoxide alarm , Smoke alarm", "Heather Cottage - Beautiful Wetland Views" },
                    { "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c", "Free cancellation before May 19. Cancel before check-in on May 24 for a partial refund.", "This is a guitar-shaped country house located in Icheon, a ceramic art village. It is a private house with a spacious terrace on the 3rd floor of the Sera Guitar Culture Center, famous for its unique appearance in the Icheon Ceramic Art Village, which blends in very well with nature.", "Check-in: 3:00 PM - 12:00 AM  , Checkout before 11:00  AM , 2 guests maximum", true, 33.9249m, 11, 18.4241m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 210m, 1, "Carbon monoxide alarm not reported , Smoke alarm , Must climb stairs", "Kai Cottage" },
                    { "efd964ab-dceb-4b96-b113-665c5684a102", "Free cancellation before Apr 26. Cancel before check-in on May 1 for a partial refund.", "Two hours from Bogotá on the Bogotá-Sasaima road, live the unique experience of staying in a tree eight meters high.Wake up to the chirping of birds and fall asleep to the sound of the stream below.Enjoy a five-star suite with all the amenities in the branches of the trees.The cabin has hot water, a mini-fridge, and the most spectacular view.", "Check-in brfore 3:00 PM , Checkout before 12:00 PM , 3 guests maximum", true, 4.96705m, 22, -74.43512m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 100m, 4, "carbon monoxide alarm  , No Smoke alarm , Nearby lake, river, other body of water", "The most spectacular treehouse in Colombia." },
                    { "f1e8be41-4fd5-47e4-8960-12d8f4afc273", "Free cancellation before May 5. Cancel before check-in on May 9 for a full refund.", "Welcome to our brand new one-bedroom flat offering incredible views of Business Bay canal and the iconic Burj Khalifa.", "Check-in brfore 1:00 Am , Checkout before 11:00 AM , 1 guests maximum", true, 25.2769m, 20, 55.2962m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 400m, 1, "carbon monoxide alarm  , Smoke alarm", "Cosy flat in the heart of Dubai" },
                    { "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1", "Free cancellation before May 19. Cancel before check-in on May 24 for a partial refund.", "This is a guitar-shaped country house located in Icheon, a ceramic art village. It is a private house with a spacious terrace on the 3rd floor of the Sera Guitar Culture Center, famous for its unique appearance in the Icheon Ceramic Art Village, which blends in very well with nature.", "Check-in: 3:00 PM - 12:00 AM  , Checkout before 11:00  AM , 2 guests maximum", true, 37.3154m, 10, 127.4052m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 180m, 1, "Carbon monoxide alarm not reported , Smoke alarm , Must climb stairs", "Emotional healing accommodation in Icheon-si, near Seoul" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "06dbae08-bc6b-4ca6-9162-3213784b9971");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "0bb50f31-e322-4b76-97dd-6a7fcf585d33");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "294e2751-203b-4beb-b21e-0bb96f082d7c");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "2e3ed231-a2a6-4961-a1ba-f232d56c6f35");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "3c0e361a-51df-4e03-b8d0-2d7601aa60f6");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "4b04a76a-1608-4a8f-b09c-8d9043b83e16");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "52a8df7d-c0b2-4ee3-8369-9daed4885f9f");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "763e6c5f-1ad1-4071-b0e6-55e924624198");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "a555515a-ff8a-4741-b0a4-db9be729198e");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "c10d2d46-869a-46bc-a46d-90bdd958c252");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "c150e428-1c9a-43a2-be07-f4366875f1ce");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "c5c0d4db-b048-4ee4-8835-344900fd35b2");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "efd964ab-dceb-4b96-b113-665c5684a102");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "f1e8be41-4fd5-47e4-8960-12d8f4afc273");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "3e7f99ab-228a-4d90-91c4-6adf8c12e048",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Relax with this listing Small 2-room 7-bed apartment near Alharam Al Makkah with a maximum of 10 to 12 minutes' walk away...", 6000m, 3 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId", "Title" },
                values: new object[] { "Romantic Loft with mezzanine and large balcony in front of the sea, double bed and 1 single bed, tv, wi-fi, fan...", 1300m, 2, "(4 charming oceanfront loft!" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Updated pool and spa! Sitting on 100 acres, Hawkeye House, featured on the cover of the May 2019 issue of Dwell Magazine...", 15000m, 1 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Elegant apartment inside the famous castle in Nolo, a royal choice right in the center of Milan...", 5000m, 2 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "Set in an architectural prize-winning building, this modern Barcelona apartment beauty has impressive detail...", 6500m, 2 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "cc4e48ea-ca54-4d32-a448-3c2c9d14f936",
                columns: new[] { "Description", "PricePerNight" },
                values: new object[] { "Enjoy your stay with Panoramic View of the giza pyramids and sphinx .Yes! view and pictures are all 100% real...", 3000m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f",
                columns: new[] { "Description", "PricePerNight" },
                values: new object[] { "Interior designer's own guesthouse, this unique place has a style all its own...", 9000m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7",
                columns: new[] { "Description", "PricePerNight", "PropertyTypeId" },
                values: new object[] { "To give you the best experience of the authentic Bedouin life style, we will gather around the fire...", 2200m, 4 });
        }
    }
}
