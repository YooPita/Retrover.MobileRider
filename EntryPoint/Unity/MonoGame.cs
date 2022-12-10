using UnityEngine;
using Retrover.Scenes.Objects;
using UnityEngine.SceneManagement;

namespace Retrover.EntryPoint.Unity
{
    public class MonoGame : MonoBehaviour
    {
        private async void Start()
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            var scenes = new UnityScenes(new SceneSwitch());
            scenes.LoadMainMenuAsync();
            Debug.Log("Scene loading ...");
        }
    }
}
