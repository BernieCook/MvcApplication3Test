using System.ComponentModel.DataAnnotations;

namespace MvcApplication3.Models
{
    public class FantaModel
    {
        [Required]
        public Drinker Drinker { get; set; }
        
        [Required]
        public bool IsLoved { get; set; }
    }

    public class Drinker
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
