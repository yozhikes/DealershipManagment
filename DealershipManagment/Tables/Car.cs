using System;
using System.Collections.Generic;

namespace DealershipManagment;

public partial class Car
{
    public Guid IdCar { get; set; }

    public Guid MarkId { get; set; }

    public int Drive { get; set; }

    public int Transmission { get; set; }

    public int BodyType { get; set; }

    public int EngineType { get; set; }

    public int ReleaseYear { get; set; }

    public string Vin { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Notes { get; set; }

    public int Status { get; set; }

    public string Model { get; set; } = null!;

    public virtual Mark Mark { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
