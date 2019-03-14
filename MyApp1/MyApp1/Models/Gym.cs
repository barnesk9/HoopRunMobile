using System;

namespace MyApp1.Models
{
    public class Gym
    {
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Coordinates { get; set; }
        public string Summary { get { return String.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", Name,AddressLine1,AddressLine2,City,State,ZipCode); } }
    } 
}