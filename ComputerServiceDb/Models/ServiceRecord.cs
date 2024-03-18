using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDb.Models
{
    public class ServiceRecord:BaseModel
    {
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public string? DeviceType { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? SerialNumber { get; set; }
        public string? MalfunctionDescription { get; set; }
        public DateTime? AcceptanceDate { get; set; }
        public DateTime? EstimatedCompletionDate { get; set;}
        public int ServiceStatusId { get; set; }
        public ServiceStatus ServiceStatus { get; set; }
    }
}
