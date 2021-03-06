using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALoGaucho.CryptoAnalyzer.Domain.Models;

namespace ALoGaucho.CryptoAnalyzer.Domain.Services.Implementation
{
    public class TrendsService: ITrendsService
    {
        public IList<Trend> GetTrends(int nrOfPosts)
        {
            var result = new List<Trend>();
            result.Add(new Trend
            {
                CoinName = "WABI",
                NrOfSearches = 98
            });
            result.Add(new Trend
            {
                CoinName = "XVZ",
                NrOfSearches = 54
            });
            return result;
        }

    }
}
