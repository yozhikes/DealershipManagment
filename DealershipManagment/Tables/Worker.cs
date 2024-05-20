using System;
using System.Collections.Generic;

namespace DealershipManagment.Tables;

public partial class Worker
{
    public Guid IdWorker { get; set; }

    public string Fio { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string TelNum { get; set; } = null!;

    public int RoleId { get; set; }

    public int Status { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
