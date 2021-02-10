using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantAssignFeb9th.Models
{
    public enum Cusinetype
    {
        None,
        Italian,
        French,
        Indian
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Cusinetype Cusine { get; set; }
    }
}