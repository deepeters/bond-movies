using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BondMovies.Models
{
    public class GadgetModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName ("Appears in this Movie")]
        public string AppersIn { get; set; }
        [Required]
        [DisplayName("James Bond is Plyaed by")]
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