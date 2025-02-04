using System.Text;

namespace payton_supplementt_p1_2
{
    public class payton_supplementt_p1_2
    {
        public static double GenerateNormalRandom(double mean, double stdDev, Random random = null)
        {
            random ??= new Random();
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
