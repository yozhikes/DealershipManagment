using System;
using System.Collections.Generic;

namespace DealershipManagment.Tables;

public partial class Role
{
    public int IdRole { get; set; }

    public string NameRole { get; set; } = null!;

    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
}
