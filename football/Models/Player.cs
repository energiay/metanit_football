using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace football.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }

        /*public Player (string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }*/
    }
}