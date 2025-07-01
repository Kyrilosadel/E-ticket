using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_ticket.Models.ViewModels
{
    public class MovieFiltersVM
    {
        public string? MovieName { get; set; }
        public string? CinemaName { get; set; }
        public int? CategoryId { get; set; }
        public string? Status { get; set; }

    }
}

