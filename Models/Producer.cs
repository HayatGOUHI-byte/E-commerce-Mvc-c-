using System.ComponentModel.DataAnnotations;

namespace E_commerce_Mvc_app.Models
{
    public class Producer
    {
        [key]
        public int ProducerId { get; set; }
        public string FullName{ get; set; }
        public string PictureProfileUrl { get; set; }
        public string Bio { get; set; }
    }
}
