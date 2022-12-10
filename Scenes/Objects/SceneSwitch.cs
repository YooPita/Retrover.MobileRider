using Cysharp.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Retrover.Scenes.Contracts;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Retrover.Scenes.Objects
{
    public class SceneSwitch : ISceneSwitch
    {
        public void LoadSceneAsync(string sceneName)
        {
            Debug.Log($"Scene loading {sceneName}");
            PerformSceneLoading(sceneName);
            //await PerformSceneLoading(sceneName);
            //UniTask uniTask = new UniTask(() => PerformSceneLoading(sceneName));
            Debug.Log($"Scene was loaded {sceneName}");
        }

        private void PerformSceneLoading(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
            //var sceneAsync = SceneManager.LoadSceneAsync(sceneName);
            //sceneAsync.allowSceneActivation = false;
            //while (sceneAsync.progress < 0.9f) { }
            //sceneAsync.allowSceneActivation = true;
        }
    }
}
