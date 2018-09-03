using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GamesStore.Common.Admin.BindingModels
{
    public class CategoryBindingModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [RegularExpression("^(?=.*?[A-Za-z])[^0-9]+$", ErrorMessage = "No Numbers Allowed")]
        public string Name { get; set; }
        
    }
}
