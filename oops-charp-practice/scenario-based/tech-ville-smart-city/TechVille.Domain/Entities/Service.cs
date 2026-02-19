using System;

namespace TechVille.Domain.Entities
{
    /// <summary>
    /// Represents a generic city service.
    /// </summary>
    public class Service
    {
        // Private fields (Encapsulation)
        private string _serviceName;
        private decimal _serviceCost;

        /// <summary>
        /// Public read-only property for service name.
        /// </summary>
        public string ServiceName => _serviceName;

        /// <summary>
        /// Public read-only property for service cost.
        /// </summary>
        public decimal ServiceCost => _serviceCost;

        /// <summary>
        /// Constructor to initialize service.
        /// </summary>
        public Service(string serviceName, decimal serviceCost)
        {
            _serviceName = serviceName;
            _serviceCost = serviceCost;
        }

        /// <summary>
        /// Virtual method to describe service.
        /// </summary>
        public virtual void DescribeService()
        {
            Console.WriteLine($"Service: {_serviceName}, Cost: {_serviceCost:C}");
        }
    }
}
