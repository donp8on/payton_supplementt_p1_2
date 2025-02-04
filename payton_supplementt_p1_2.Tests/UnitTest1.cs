namespace payton_supplementt_p1_2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldTestRandomNumberNormalDistribution()
        {
            double mean = 50;
            double stdDev = 10;
            int sampleSize = 1000;
            double sum = 0;
            double sumSquares = 0;

            for (int i = 0; i < sampleSize; i++)
            {
                double value = GenerateNormalRandom(mean, stdDev);
                sum += value;
                sumSquares += Math.Pow(value - mean, 2);
            }

            double actualMean = sum / sampleSize;
            double actualStdDev = Math.Sqrt(sumSquares / sampleSize);

            Assert.InRange(actualMean, mean - 1, mean + 1);
        }
    }
}