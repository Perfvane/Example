using Xunit;

namespace Perfvane.Example.Tests
{
    public class AnomaliesFacts
    {
        [Fact]
        public void Degradation()
        {
            Anomalies.Degradation();
        }

        [Fact]
        public void Acceleration()
        {
            Anomalies.Acceleration();
        }

        [Fact]
        public void Bimodal()
        {
            Anomalies.Bimodal();
        }

        [Fact]
        public void Multimodal()
        {
            Anomalies.Multimodal();
        }

        [Fact]
        public void Changepoint()
        {
            Anomalies.Changepoint();
        }

        [Fact]
        public void Changepoint2()
        {
            Anomalies.Changepoint2();
        }
    }
}
