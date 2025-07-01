using System;
using System.Collections.Generic;

namespace E_ticket.Models;

public partial class Image
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int MovieId { get; set; }

    public virtual Movie Movie { get; set; } = null!;
}
