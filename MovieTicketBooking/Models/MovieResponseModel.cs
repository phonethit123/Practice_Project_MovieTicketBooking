using MovieTicketBooking.Models.ViewModels;

namespace MovieTicketBooking.Models
{
    public class MovieResponseModel
    {
        public List<MovieViewModel> MovieList { get; set; }
        public int RowCount { get; set; }  

    }
}
