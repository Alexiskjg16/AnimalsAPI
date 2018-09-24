using System;

namespace SafariAPI{

    public class SeenAnimal
    {
        public int ID { get; set; }
        public string Species { get; set; }
        public int Count { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}