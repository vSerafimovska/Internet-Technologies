using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FriendMVC.Models
{
    public class FriendModel
    {
        [Required(ErrorMessage = "Ве молиме внесете ID!")]
        [Range(0, 200, ErrorMessage = "Внесете ID во ранг од 0 до 200!!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете име!")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете место на живеење!")]
        [Display(Name = "Mesto na ziveenje")]
        public string MestoZiveenje { get; set; }
    }
}