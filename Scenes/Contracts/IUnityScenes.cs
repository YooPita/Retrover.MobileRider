using Retrover.Scenes.Objects;
using System.Threading.Tasks;

namespace Retrover.Scenes.Contracts
{
    public interface IUnityScenes
    {
        void LoadGameAsync();
        void LoadMainMenuAsync();
    }
}