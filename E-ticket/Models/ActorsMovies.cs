using System;
using System.Collections.Generic;

namespace E_ticket.Models;

public partial class ActorsMovies
{
    public int Id { get; set; }

    public int ActorsId { get; set; }

    public int MoviesId { get; set; }

    public virtual Actor Actors { get; set; } = null!;

    public virtual Movie Movies { get; set; } = null!;
}
