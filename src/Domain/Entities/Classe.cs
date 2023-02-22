using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Classe : BaseAuditableEntity 
{


    public int ClassId { get; set; }

    public string? NomClasse { get; set; }

    public string? EmailClasse { get; set; }

}
