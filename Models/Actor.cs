using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_commerce_Mvc_app.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string FullName { get; set; }
        public string PictureProfileUrl { get; set; }
        public string Bio { get; set; }
        public List <Actor_Movie> Actors_Movies { get; set; }
    }
}
