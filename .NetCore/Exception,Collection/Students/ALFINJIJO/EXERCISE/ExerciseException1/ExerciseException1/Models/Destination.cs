using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Destination() { }
        public Destination(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
