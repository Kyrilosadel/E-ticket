﻿using System;
using System.Collections.Generic;

namespace E_ticket.Models;

public partial class Cinema
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? CinemaLogo { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
