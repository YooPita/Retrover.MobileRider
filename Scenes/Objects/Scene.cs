using Cysharp.Threading.Tasks;
using System;
using UnityEngine.SceneManagement;

namespace Retrover.MobileRider.Scenes.Objects
{
    public class Scene : IEquatable<Scene>, IEquatable<string>
    {
        public Scene(string name)
        {
            _name = name;
        }

        private readonly string _name;

        public async UniTask LoadAsync()
        {
            await SceneManager.LoadSceneAsync(_name);
        }

        public bool Equals(string other)
        {
            return _name == other;
        }

        public bool Equals(Scene other)
        {
            return other.Equals(_name);
        }
    }
}
