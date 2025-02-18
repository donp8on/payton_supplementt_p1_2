﻿using System.Text;

namespace payton_supplementt_p1_2
{
    public class payton_supplementt_p1_2
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Generates a random number from a normal distribution given a standard deviation and mean.
        /// </summary>
        /// <param name="mean">The mean of the distribution.</param>
        /// <param name="stdDev">The standard deviation of the distribution.</param>
        /// <returns>Returns a normally distributed random number given a standard deviation and mean.</returns>
        public static double GenerateNormalRandom(double mean, double stdDev)
        {
            double u1 = 1.0 - _random.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - _random.NextDouble();
            double normal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return mean + stdDev * normal; //function returns random normal(mean,stdDev^2)
        }

        /// <summary>
        /// Generates a random password string of a given length.
        /// </summary>
        /// <param name="length">The length of the password.</param>
        /// <returns>A password that consists of the character set of A-Z, a-z, 0-9, 
        /// and underscore given a length</returns>
        /// <exception cref="ArgumentException">Throws an exception if given length is less than 0.</exception>
        public static string GeneratePasswordString(int length, Random random = null)
        {
            if (length <= 0) throw new ArgumentException("Length must be > than 0.");

            const string charSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(charSet.Length);
                password.Append(charSet[index]);
            }

            return password.ToString();
        }

        /// <summary>
        /// Generates a random color’s hexstring and RGB values.
        /// </summary>
        /// <returns>A tuple containing a hex string and an RGB integer tuple</returns>
        public static (string, (int, int, int)) GenerateRandomColor()
        {
            int r = _random.Next(256);
            int g = _random.Next(256);
            int b = _random.Next(256);
            string hex = $"#{r:X2}{g:X2}{b:X2}";
            return (hex, (r, g, b));
        }
    }
}
