using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GamesStore.Common.Admin.BindingModels
{
    public class UserInfoBindingModel
    {

        public string Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(30)]
        [DataType(DataType.Text)]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Addres { get; set; }
    }
}
