namespace payton_supplementt_p1_2
{
    public class payton_supplementt_p1_2
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Generates a random number from a normal distribution given a standard deviation and mean.
        /// </summary>
        /// <param name="mean">The mean of the distribution.</param>
        /// <param name="stdDev">The standard deviation of the distribution.</param>
        /// <returns>Returns a normally distributed random number given a standard deviation and mean.</returns>
        public static double GenerateNormalRandom(double mean, double stdDev)
        {
            double u1 = 1.0 - random.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - random.NextDouble();
            double normal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return mean + stdDev * normal; //function returns random normal(mean,stdDev^2)
        }

        public static string GeneratePasswordString(int length, Random random = null)
        {
            throw new NotImplementedException();
        }

        public static (string, (int, int, int)) GenerateRandomColor(Random random = null)
        {
            throw new NotImplementedException();
        }
    }
}
