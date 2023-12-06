
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual string? Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.UtcNow;
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
