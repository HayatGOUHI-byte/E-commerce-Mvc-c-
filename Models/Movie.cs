﻿using System.ComponentModel.DataAnnotations;
using  E_commerce_Mvc_app.Data;



namespace E_commerce_Mvc_app.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }
    }
}