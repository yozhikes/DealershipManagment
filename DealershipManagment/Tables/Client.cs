using System;
using System.Collections.Generic;

namespace DealershipManagment;

public partial class Client
{
    public Guid IdClient { get; set; }

    public string Fio { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string TelNum { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
