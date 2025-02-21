using MovieTicketBooking.Models;
using MovieTicketBooking.Models.ViewModels;
using MovieTicketBooking.Services;
using System.Runtime.InteropServices;
namespace MovieTicketBooking.Pages
{
    public partial class PageMain
    {
        private PageChangeEnum _currentPage = PageChangeEnum.PageMovie;
        private int _moviewId = 0;
        private CinemaRoomViewModel _roomData = null;

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
        }

        private async Task ShowCinemaClick(MovieViewModel model) 
        {
            _moviewId=model.MovieId;
        }
        private void RoomSeatClick(CinemaRoomViewModel model)
        {
            _roomData = model;
        }
        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}
