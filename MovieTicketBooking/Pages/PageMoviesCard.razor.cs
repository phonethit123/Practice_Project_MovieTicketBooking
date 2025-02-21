using Microsoft.AspNetCore.Components;
using MovieTicketBooking.Models;
using MovieTicketBooking.Models.ViewModels;
using MovieTicketBooking.Services;

namespace MovieTicketBooking.Pages
{
    public partial class PageMoviesCard
    {
        private MovieResponseModel? _movieModel {  get; set; }
        private List<MovieViewModel> _movieList { get; set; }
        private string? title {  get; set; }
        private int _pageCount = 0;
        private int _pageSize = 3;
        [Parameter] public EventCallback<MovieViewModel?> ShowCinema { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _movieModel = await _dbService.GetMovieListByPagination(1, 3);
            _movieList = _movieModel.MovieList;
            _pageCount = _movieModel.getTotalPage(_pageSize);
        }
        async Task PageChanged(int pageNo = 1)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                _movieModel = await _dbService.GetMovieListByPagination(pageNo, 3);
                _movieList = _movieModel.MovieList;
                _pageCount = _movieModel.getTotalPage(_pageSize);
            }
            else
            {
               // await SearchMovie(pageNo);
            }
        }

    }
}
