namespace TechVille.Domain.Entities
{
    /// <summary>
    /// Represents education service in TechVille.
    /// </summary>
    public class EducationService : Service
    {
        public string Level { get; private set; }

        public EducationService(decimal cost, string level)
            : base("Education Service", cost)
        {
            Level = level;
        }

        public override void DescribeService()
        {
            base.DescribeService();
            Console.WriteLine($"Education Level: {Level}");
        }
    }
}
