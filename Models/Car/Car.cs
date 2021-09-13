using System;

namespace DetailsPage.Models
{
   
    public class Car
    {
        public float Price { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }

        public DateTime Year { get; set; }
        public int Kilometer { get; set; }
        //Why I dont have to import transmission enum here?
        public Transmission TransmissionType { get; set; }
        public string PresentLocation { get; set; }
        public string RegisteredLocation { get; set; }
        public string Color { get; set; }
        public FuelType Fuel { get; set; }
        public string CarImageUrl { get; set; }

        public string OwnerComment { get; set; }


    }
}