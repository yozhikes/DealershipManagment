using System;
using System.Collections.Generic;

namespace DealershipManagment.Tables;

public partial class Report
{
    public Guid IdReport { get; set; }

    public string MonthReport { get; set; } = null!;

    public int HoursWork { get; set; }

    public decimal Salary { get; set; }

    public decimal Prize { get; set; }

    public Guid WorkerId { get; set; }

    public DateOnly DateReport { get; set; }

    public virtual Worker Worker { get; set; } = null!;
}
