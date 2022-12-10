using Retrover.Scenes.Contracts;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Retrover.Scenes.Objects
{
    public class UnityScenes : IUnityScenes
    {
        public UnityScenes(ISceneSwitch sceneSwitch)
        {
            _sceneSwitch = sceneSwitch;
        }

        private readonly ISceneSwitch _sceneSwitch;
        private readonly Scene _mainMenuScene = new Scene("MainMenu");
        private readonly Scene _gameScene = new Scene("Game");

        public void LoadMainMenuAsync() => _mainMenuScene.LoadBy(_sceneSwitch);

        public void LoadGameAsync() => _gameScene.LoadBy(_sceneSwitch);
    }
}
