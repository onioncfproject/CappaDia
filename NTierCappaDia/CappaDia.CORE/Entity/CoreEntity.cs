using CappaDia.CORE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CappaDia.CORE.Entity
{
    public abstract class CoreEntity
    {
        public CoreEntity()
        {
            Status = Status.Created;
            CreatedDate = DateTime.Now;
            this.CreatedADUserName = WindowsIdentity.GetCurrent().Name;
            this.CreatedComputerName = Environment.MachineName;
            CreatedIp = "123";
        }
        public Guid Id { get; set; }
        
        public Status Status { get; set; }


        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIp { get; set; }
        public string CreatedADUserName { get; set; }
        public int? CreatedBy { get; set; }


        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedADUserName { get; set; }
        public int? ModifiedBy { get; set; }

    }
}
