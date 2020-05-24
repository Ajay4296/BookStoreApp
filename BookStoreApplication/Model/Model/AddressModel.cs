using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Model
{
   public class AddressModel
    {
        [Key]    
        [Required]
        public string Email { get; set; }
       [Required(ErrorMessage = "Enter your Full Name")]
       [Display(Name = "Full Name")]
       [StringLength(25)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Enter your Full Name")]
        [MaxLength(10)]
        public string ContactNumber { get; set; }
       
        public string DeliveryAddress { get; set; }

        public string ZipCode { get; set; }
        
        public string CityTown { get; set; }

        public string LandMark { get; set; }    

        public string AddressType { get; set; }
    }
}
 