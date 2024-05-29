using System;
using System.Collections.Generic;

namespace DealershipManagment;

public partial class Mark
{
    public Guid IdMark { get; set; }

    public string NameMark { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
