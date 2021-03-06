using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ALoGaucho.CryptoAnalyzer.ApiHost.Models;
using ALoGaucho.CryptoAnalyzer.Domain.Models;

namespace ALoGaucho.CryptoAnalyzer.ApiHost.Mappers
{
    public class TrendsMapper
    {
        public static TrendResponse ToModel(Trend src)
        {
            return new TrendResponse
            {
                CoinName = src.CoinName,
                NrOfSearches = src.NrOfSearches
            };
        }

    }
}