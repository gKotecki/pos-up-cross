using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using UberSeries.Models;

namespace UberSeries.Infra.Api
{
    [Headers("Content-Type: application/json")]
    public interface ITmdbApi
    {
        [Get("/tv/popular?api_key=(apiKey")]
        Task<SerieResponse> GetSerieResponseAsync(string apiKey);
    }
}
