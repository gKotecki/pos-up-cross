using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UberSeries.Models;

namespace UberSeries.Services
{
    public interface ISerieService
    {
        Task<SerieResponse> GetSeriesAsync();
    }
}
