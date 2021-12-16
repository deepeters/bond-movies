using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BondMovies.Models
{
    public class GadgetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AppersIn { get; set; }
        public string WithThisActor { get; set; }
         
        public GadgetModel()
        {
            Id = -1;
            Name = "Nameless";
            Description = "Nothing";
            AppersIn = "Nowhere";
            WithThisActor = "Noone";
        }

        public GadgetModel(int id, string name, string description, string appersIn, string withThisActor)
        {
            Id = id;
            Name = name;
            Description = description;
            AppersIn = appersIn;
            WithThisActor = withThisActor;
        }
    }
}