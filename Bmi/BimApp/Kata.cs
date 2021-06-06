using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BimApp
{
    public class Kata
    {
        public string Bmi(double weight, double height)
        {

            var bmi = (weight / Math.Pow(height, 2));

            if (bmi <= 18.5) return "Underweight";

            if (bmi <= 25.0) return "Normal";

            if (bmi <= 30.0) return "Overweight";

            if (bmi > 30) return "Obese";

            return string.Empty;
        }

        public string BmiV2(double weight, double height)
        {
            var bmi = weight / (height * height);
            switch (bmi)
            {
                case double i when bmi <= 18.5:
                    return "Underweight";
                case double i when bmi <= 25.0:
                    return "Normal";
                case double i when bmi <= 30.0:
                    return "Overweight";
                default:
                    return "Obese";
            }
        }

        public string BmiV3(double weight, double height)
        {
            var bmi = weight / Math.Pow(height, 2);
            return bmi switch
            {
                var x when x <= 18.5 => "Underweight",
                var x when x <= 25 => "Normal",
                var x when x <= 30 => "Overweight",
                _ => "Obese"
            };
        }

        public string BmiV4(double weight, double height) => (weight = weight / height / height) > 30 ? "Obese" : weight > 25 ? "Overweight" : weight > 18.5 ? "Normal" : "Underweight";
    }
}
