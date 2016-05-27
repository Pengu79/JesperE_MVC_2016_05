using System;
using System.ComponentModel.DataAnnotations;

namespace JesperE_MVC_2016_05.Models
{
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field,AllowMultiple = false)]
    sealed public class CustomAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            
            string checkPattern = "^ p -\\d{ 4}";
            
            if(System.Text.RegularExpressions.Regex.IsMatch((string)value,checkPattern))
                return true;
            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return "ProduktNumber måste börja på p- följt av 4 siffror";
        }
    }
}