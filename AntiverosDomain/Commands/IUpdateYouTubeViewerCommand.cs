using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiverosSolution.AntiverosDomain.Models;

namespace AntiverosSolution.AntiverosDomain.Commands
{
    public interface IUpdateYouTubeViewerCommand
    {
        Task Execute(YouTubeViewer youTubeViewer);
    }
}
