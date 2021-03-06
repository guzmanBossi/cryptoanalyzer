using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ALoGaucho.CryptoAnalyzer.ApiHost.Mappers;
using ALoGaucho.CryptoAnalyzer.ApiHost.Models;
using ALoGaucho.CryptoAnalyzer.Domain.Services;

namespace ALoGaucho.CryptoAnalyzer.ApiHost.Controllers
{
    public class TrendsController : ApiController
    {
        private readonly ITrendsService _trendsService;

        public TrendsController(ITrendsService trendsService)
        {
            _trendsService = trendsService;
        }

        public IList<TrendResponse> GetTrends(int nrOfPosts)
        {

            var trends = _trendsService.GetTrends(nrOfPosts);
            return trends.Select(TrendsMapper.ToModel).ToList();

        }



    }
}
