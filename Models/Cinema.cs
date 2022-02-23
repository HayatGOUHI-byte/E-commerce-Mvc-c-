using System.ComponentModel.DataAnnotations;

namespace E_commerce_Mvc_app.Models
{
    public class Cinema
    {
        [Key]
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public  <Movie> movies { get; set; }
    }
}
