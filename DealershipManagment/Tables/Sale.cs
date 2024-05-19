using System;
using System.Collections.Generic;

namespace DealershipManagment.Tables;

public partial class Sale
{
    public Guid IdSale { get; set; }

    public Guid CarId { get; set; }

    public decimal Total { get; set; }

    public Guid ClientId { get; set; }

    public Guid WorkerId { get; set; }

    public string? Notes { get; set; }

    public DateTime DateSale { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual Worker Worker { get; set; } = null!;
}
