using Retrover.Scenes.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Retrover.Scenes.Objects
{
    public class Scene : IEquatable<Scene>, IEquatable<string>
    {
        public Scene(string name)
        {
            _name = name;
        }

        private readonly string _name;

        public void LoadBy(ISceneSwitch sceneSwitch)
        {
            sceneSwitch.LoadSceneAsync(_name);
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
