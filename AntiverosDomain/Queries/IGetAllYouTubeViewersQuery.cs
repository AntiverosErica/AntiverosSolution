using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiverosSolution.AntiverosDomain.Models;

namespace AntiverosSolution.AntiverosDomain.Queries
{
    public interface IGetAllYouTubeViewersQuery
    {
        Task<IEnumerable<YouTubeViewer>> Execute();
    }
}
