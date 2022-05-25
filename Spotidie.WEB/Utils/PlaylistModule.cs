using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;

namespace Spotidie.Utils;

public class PlaylistModule : NinjectModule
{
    public override void Load()
    {
        Bind<IPlaylistService>().To<PlaylistService>();
    }
}