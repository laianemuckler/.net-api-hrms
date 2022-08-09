using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }

        DateTime CreateDate { get; set; }
        DateTime ModifiedDate { get; set; }
        string? CreateBy { get; set; }
        string? ModifiedBy { get; set; }
    }
}
