using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FirstMVC.Models
{
    public class ValidJoinDate : ValidationAttribute
    {      
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.Customer)validationContext.ObjectInstance;
            DateTime _dateJoin = Convert.ToDateTime(value); 
            if (_dateJoin < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Join date can not be greater than current date.");
            }
        }        
    }
}