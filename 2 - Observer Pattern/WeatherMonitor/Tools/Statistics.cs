using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor.Tools
{
    public class Statistics
    {
        private Statistics()
        {

        }
        
        /// <summary>
        /// Returns the maximum value from the list.
        /// </summary>
        /// <param name="values">List of values.</param>
        /// <param name="maxValueExtent">Any value lesser than the least maximum value.</param>
        /// <returns></returns>
        public static double Max(List<double> values, double maxValueExtent = -100000)
        {
            if (values.Count == 0) { return 0; }
            double maxValue = maxValueExtent;

            foreach (double value in values)
            {
                maxValue = Math.Max(value, maxValue);
            }
            return maxValue;
        }

        /// <summary>
        /// Returns the minimum value from the list.
        /// </summary>
        /// <param name="values">List of values.</param>
        /// <param name="minValueExtent">Any value greater than the greatest minimum value.</param>
        /// <returns></returns>
        public static double Min(List<double> values, double minValueExtent = 100000)
        {
            if (values.Count == 0) { return 0; }
            double minValue = minValueExtent;

            foreach (double value in values)
            {
                minValue = Math.Min(value, minValue);
            }
            return minValue;
        }

        /// <summary>
        /// Returns the average value from the list.
        /// </summary>
        /// <param name="values">List of values.</param>
        /// <returns></returns>
        public static double Average(List<double> values)
        {
            if (values.Count == 0) { return 0; }
            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }
            return sum / values.Count;
        }
    }
}
