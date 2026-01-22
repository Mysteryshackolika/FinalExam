using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyFinalProject.Models.Base;

namespace MyFinalProject.Models
{
    public class Game : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        
        [MaxLength(50)]
        public int Price { get; set; }
        [MaxLength(50)]
      
        public string  Genre { get; set; }

    }
}
