using System;
using System.ComponentModel.DataAnnotations;

namespace DioklecijanovaLegija.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var member = (Member)validationContext.ObjectInstance;

            //if (member.EventId == Event.Unknown)
            //    return ValidationResult.Success;



            if (member.BirthDate == null)
                return new ValidationResult("Birthdate is required.");

            var dateNow = DateTime.Today.Day + DateTime.Today.Month * 30 + DateTime.Today.Year * 365;
            var dateThen = member.BirthDate.Value.Day + member.BirthDate.Value.Month * 30 + member.BirthDate.Value.Year * 365;
            var age = (dateNow - dateThen) / 365;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Member should be at least 18 year old to perform an event.");

        }
    }
}
