using Retrover.MobileRider.Scenes.Primitives;
using UnityEngine;

namespace Retrover.MobileRider.EntryPoint.Unity
{
    public class MonoGame : MonoBehaviour
    {
        private async void Start()
        {
            var unityScenes = new UnityScenes();
            await unityScenes.MainMenu.LoadAsync();
        }


    }
}
