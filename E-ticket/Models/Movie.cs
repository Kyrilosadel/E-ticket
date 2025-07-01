using System;
using System.Collections.Generic;

namespace E_ticket.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int MovieStatus { get; set; }

    public DateTime StartDate { get; set; }

    public int CinemaId { get; set; }

    public int CategoryId { get; set; }

    public int? ActorId { get; set; }

    public DateTime EndDate { get; set; }

    public string ImgUrl { get; set; } = null!;

    public string TrailerUrl { get; set; } = null!;

    public virtual Actor? Actor { get; set; }

    public virtual ICollection<ActorsMovies> ActorMovies { get; set; } = new List<ActorsMovies>();

    public virtual Category Category { get; set; } = null!;

    public virtual Cinema Cinema { get; set; } = null!;

    public virtual ICollection<MovieImage> Images { get; set; } = new List<MovieImage>();
}
