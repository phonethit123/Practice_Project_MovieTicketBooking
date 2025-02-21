using MovieTicketBooking.Models;

namespace MovieTicketBooking.Services
{
    public class PageChangeStateContainer
    {
        private PageChangeEnum? pageChange;

        public PageChangeEnum CurrentPage
        {
            get => pageChange?? PageChangeEnum.PageMovie;
            set
            { 
                pageChange = value;
                NotifyStageChanged();

            }

        }
        public event Action? OnChange;
        private void NotifyStageChanged() => OnChange?.Invoke();
    }
}
