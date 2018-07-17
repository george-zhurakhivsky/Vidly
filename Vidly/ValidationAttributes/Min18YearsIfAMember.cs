using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ValidationAttributes
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if(customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("The Date of Birth field is required.");
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            if ((customer.Birthdate.Value.Month > DateTime.Now.Month) ||
                (customer.Birthdate.Value.Month == DateTime.Now.Month && customer.Birthdate.Value.Day > DateTime.Now.Day))
                age--;
            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 y.o. to go on a membership.");
        }
    }
}