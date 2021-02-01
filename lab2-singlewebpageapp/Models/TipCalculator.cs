using System.ComponentModel.DataAnnotations;

namespace lab2_singlewebpageapp.Models
{
    public class TipCalculator
    {

        [Required(ErrorMessage = "Please enter a value for the cost of your meal.")] // error message check
        [Range(0.0, 10000.0, ErrorMessage = "Cost of meal must be greater than zero")]
        // nullable attirbute "?" - ANY value including null, we put this here because first run sanity check for users
        public double? MealCost { get; set; } // accessor and mutator : get and set

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            else
            {
                return 0;
            }
        }
    }
}
