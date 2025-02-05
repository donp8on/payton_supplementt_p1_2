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
                double value = payton_supplementt_p1_2.GenerateNormalRandom(mean, stdDev);
                sum += value;
                sumSquares += Math.Pow(value - mean, 2);
            }

            double actualMean = sum / sampleSize;
            double actualStdDev = Math.Sqrt(sumSquares / sampleSize);

            Assert.InRange(actualMean, mean - 1, mean + 1);
        }

        [Fact]
        public void ShouldGeneratePasswordWithLengthAndReturnsConsistentResult()
        {
            int length = 10;
            Random seededRandom = new Random(42);

            string password1 = payton_supplementt_p1_2.GeneratePasswordString(length, seededRandom);
            string password2 = payton_supplementt_p1_2.GeneratePasswordString(length, new Random(42));

            Assert.Equal(password1, password2);
        }

        [Fact]
        public void ShouldGenerateTupleForRandomColor()
        {
            (string hex, (int, int, int) rgb) = payton_supplementt_p1_2.GenerateRandomColor();

            Assert.Matches(@"^#[0-9A-F]{6}$", hex);
            Assert.InRange(rgb.Item1, 0, 255);
            Assert.InRange(rgb.Item2, 0, 255);
            Assert.InRange(rgb.Item3, 0, 255);

            string hexFromRgb = $"#{rgb.Item1:X2}{rgb.Item2:X2}{rgb.Item3:X2}";
            Assert.Equal(hexFromRgb, hex);
        }
    }
}