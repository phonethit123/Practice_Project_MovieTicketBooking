using MovieTicketBooking.Models;

namespace MovieTicketBooking.Services
{
    public interface IDbService
    {
        Task<MovieResponseModel?> GetMovieListByPagination(int PageNo, int PageSize);
    }
}
