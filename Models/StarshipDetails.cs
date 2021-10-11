using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_240921.Models
{
    public class StarshipDetails
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int CostInCredits { get; set; }
        public int Length { get; set; }
        public int MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public int Passengers { get; set; }
        public decimal CargoCapicity { get; set; }
        public string Consumables { get; set; }
        public float HyperdriveRating { get; set; }
        public int MGLT { get; set; }
        public string StarshipClass { get; set; }
        public  List<string> Pilots { get; set; }

        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string URL { get; set; }


    }
}
