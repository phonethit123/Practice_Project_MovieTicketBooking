using MovieTicketBooking.Models;
using MovieTicketBooking.Models.ViewModels;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace MovieTicketBooking.Services
{
    public static class DevCode
    {
        public static List<MovieViewModel>? Change(this List<MovieViewModel>? dataModels) 
        {
            if(dataModels == null && dataModels.Count==0) return default;
            List<MovieViewModel> viewModels = dataModels.Select(dataModel => new MovieViewModel
            {
                MovieId = dataModel.MovieId,
                MovieTitle = dataModel.MovieTitle,
                ReleaseDate = dataModel.ReleaseDate,
                Duration = dataModel.Duration,
                MoviePhoto = dataModel.MoviePhoto

            }
                ).ToList();
            return viewModels;
        }
        public static T? ToJsonObj<T>(this string jsonStr)
        {
            return JsonConvert.DeserializeObject<T>(jsonStr);

        }
        public static int getTotalPage(this MovieResponseModel moviemodel, int PageSize)
        {
            int TotalPages = moviemodel.RowCount / PageSize;
            if(moviemodel.RowCount%PageSize>0)
            {
                TotalPages++;
            }
            return TotalPages;
            
        }
    }
}
