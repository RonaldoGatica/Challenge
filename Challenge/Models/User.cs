using System;
using System.Collections.Generic;

namespace Challenge.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    // Constructor de la clase
    public User(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}
