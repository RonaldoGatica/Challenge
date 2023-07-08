using System;
using System.Collections.Generic;

namespace Challenge.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public int Iduser { get; set; }

    public string? Type { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Status { get; set; }

    public DateTime Date { get; set; }
}
