using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Practice 3.");

            Console.WriteLine("Event 1");
            Lectures lectures = new Lectures();
            lectures._addressEvent = new Address ();
            lectures._addressEvent.SetDirection("7272 E Gage Ave", "Los Angeles", "California", "USA");
            lectures.SetEvent("Lectures","Science Conference", "New technologies that drive artificial intelligence and its future benefits", "21-12-2022", "7pm", 100);
            lectures._speaker = "Roy Bosch";
            ShortDescription (lectures);

            Console.WriteLine("Event 2");
            OutdoorGatherings outDoor = new OutdoorGatherings();
            outDoor._addressEvent = new Address ();
            outDoor._addressEvent.SetDirection("Calle 60", "Barquisimeto", "Lara", "Venezuela");
            outDoor.SetEvent("Outdoor Gatherings", "Marathon", "Community marathon to promote a healthy life", "10-01-2023", "9am");
            outDoor.SetWeather ("Overcast clouds. Light air");
            StandardDetails (outDoor);
            Console.WriteLine("");

            Console.WriteLine("Event 3");
            Receptions receptions = new Receptions();
            receptions._addressEvent = new Address ();
            receptions._addressEvent.SetDirection("Avenida La Mar 576", "Barquisimeto", "Lara", "Venezuela");
            receptions.SetEvent("Reception", "Baptism and Birthday", "Jeremmy's Baptism and Birthday are all invited", "17-12-2022", "5pm");
            receptions.SetRSVP ("jeremmy@yahoo.es");

            FullDetails (receptions, receptions.GetRSVP());
            FullDetails (lectures, lectures._speaker);
            FullDetails (outDoor, outDoor.GetWeather());
            
        }

        public static void ShortDescription (Events event1){
            Console.WriteLine(event1.GetType() + ": " + event1.GetTitle());
            Console.WriteLine("Date: " + event1.GetFullDate());
            Console.WriteLine("");
        }
                        
        public static void StandardDetails (Events event1){
            //enumera el título, la descripción, la fecha, la hora y la dirección.
            Console.WriteLine("Title: " + event1.GetTitle());
            Console.WriteLine("Descriptión: " + event1.GetDescription());
            Console.WriteLine("Date: " + event1.GetFullDate());
            Console.WriteLine("Address: " + event1._addressEvent.GetDirection());
        }

        public static void FullDetails (Events event1, string specialtale){
            StandardDetails (event1);
        
            if (event1.GetTypeEvent() == "Lectures"){
                Console.WriteLine("Speaker: " + specialtale);
                Console.WriteLine("Capacity: " + event1.GetCapacity());
                Console.WriteLine("");
            }else if(event1.GetTypeEvent() == "Outdoor Gatherings"){
                Console.WriteLine("Weather: " + specialtale);
                Console.WriteLine("");
            }
            else if(event1.GetTypeEvent() == "Reception"){
                Console.WriteLine("RSVP: " + specialtale);
                Console.WriteLine("");                
            }

        }
    }
}
