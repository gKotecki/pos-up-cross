using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UberSeries.Models;

namespace UberSeries.Services
{
    public class SerieService : ISerieService
    {
        public Task<IEnumerable<SerieResponse>> GetSeriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
