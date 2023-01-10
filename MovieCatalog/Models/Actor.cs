using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public string ProfilePicURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string MoviesPlayedIn { get; set; }
    }
}