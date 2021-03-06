using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALoGaucho.CryptoAnalyzer.Domain.Models;

namespace ALoGaucho.CryptoAnalyzer.Domain.Services
{
    public interface ITrendsService
    {
        IList<Trend> GetTrends(int nrOfPosts);
    }
}
