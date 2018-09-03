using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GamesStore.Common.Admin.BindingModels
{
    public class GameBindingModel
    {
        public GameBindingModel()
        {
            Categories = new List<SelectListItem>();
        }

        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(20)]
        public string Description { get; set; }

        [Required]
        [Range(1,500)]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1,999)]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImgUrl { get; set; }

        [Required]
        public string Category { get; set; }

        //for drop down list
        public ICollection<SelectListItem> Categories { get; set; }
    }
}
