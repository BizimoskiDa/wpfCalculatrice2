using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_calculatrice
{
    /// <summary>
    /// Simple Addition Class
    /// </summary>
    public class Addition
    {
        private double val1;
        private double val2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="valeur1">First value double</param>
        /// <param name="valeur2">Second value double</param>
        public Addition(double valeur1, double valeur2)
        {
            this.val1 = valeur1;
            this.val1 = valeur2;
        }

        /// <summary>
        /// Add the two values
        /// </summary>
        /// <returns>result of sub</returns>
        public double Additionne()
        {
            return val1 + val2;
        }

        /// <summary>
        /// Sel by first value
        /// </summary>
        /// <param name="Val1"></param>
        public void setVal1(double Val1)
        {
            this.val1 = Val1;
        }

        /// <summary>
        /// Sel by second value
        /// </summary>
        /// <param name="Val1"></param>
        public void setVal2(double Val2)
        {
            this.val2 = Val2;
        }

        public double getVal1()
        {
            return this.val1;
        }

        public double getVal2()
        {
            return this.val2;
        }

        public string Affiche()
        {
            return "The sum of " + val1.ToString()
                + " and " + val2.ToString() 
                + " is " + (val1 + val2).ToString();
        }
    }
}
