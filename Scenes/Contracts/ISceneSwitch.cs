using System.Threading.Tasks;

namespace Retrover.Scenes.Contracts
{
    public interface ISceneSwitch
    {
        void LoadSceneAsync(string sceneName);
    }
}