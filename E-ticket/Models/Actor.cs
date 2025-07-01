using System;
using System.Collections.Generic;

namespace E_ticket.Models;

public partial class Actor
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Bio { get; set; } = null!;

    public string ProfilePicture { get; set; } = null!;

    public string News { get; set; } = null!;

    public virtual ICollection<ActorsMovies> ActorMovies { get; set; } = new List<ActorsMovies>();

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
