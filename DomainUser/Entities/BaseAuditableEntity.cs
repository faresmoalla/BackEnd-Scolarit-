using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainUser.Entities;
using S = System;
public abstract class BaseAuditableEntity : BaseEntity
{

    readonly DateTime _dateTime = DateTime.Now;
    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get { return _dateTime; } set { } }

    public string? LastModifiedBy { get; set; }
}

