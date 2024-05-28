using System;
using System.Collections.Generic;

namespace DealershipManagment.Tables;

public partial class Request
{
    public Guid IdRequest { get; set; }

    public Guid CarId { get; set; }

    public int StatusZayavki { get; set; }

    public string? Notes { get; set; }

    public DateTime? DateStartRepair { get; set; }

    public DateTime? DateEndRepair { get; set; }

    public decimal? Price { get; set; }

    public virtual Car Car { get; set; } = null!;
}
