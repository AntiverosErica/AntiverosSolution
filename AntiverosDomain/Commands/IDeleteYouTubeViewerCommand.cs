using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiverosSolution.AntiverosDomain.Commands
{
    public interface IDeleteYouTubeViewerCommand
    {
        Task Execute(Guid id);
    }
}
