namespace TechVille.Domain.Entities
{
    /// <summary>
    /// Represents healthcare service in TechVille.
    /// </summary>
    public class HealthcareService : Service
    {
        public bool EmergencySupport { get; private set; }

        public HealthcareService(decimal cost, bool emergencySupport)
            : base("Healthcare Service", cost)
        {
            EmergencySupport = emergencySupport;
        }

        public override void DescribeService()
        {
            base.DescribeService();
            Console.WriteLine($"Emergency Support: {EmergencySupport}");
        }
    }
}
