using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AntiverosSolution.AntiverosYouTubeViewer.Commands;
using AntiverosSolution.AntiverosYouTubeViewer.Stores;

namespace AntiverosSolution.AntiverosYouTubeViewer.ViewModels
{
    public class AddYouTubeViewerViewModel : ViewModelBase
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public AddYouTubeViewerViewModel(YouTubeViewersStore youTubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new AddYouTubeViewerCommand(this, youTubeViewersStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
