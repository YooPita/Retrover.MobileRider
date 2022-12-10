using UnityEngine;

namespace Retrover.EntryPoint.Unity
{
    public class MonoEntryPoint : MonoBehaviour
    {
        private void Start() => InstantiateGame();

        private void InstantiateGame()
        {
            if (GameAlreadyExists())
                return;
            GameObject game = new GameObject("Game");
            game.AddComponent<MonoGame>();
            DontDestroyOnLoad(game);
        }

        private bool GameAlreadyExists()
            => FindObjectOfType<MonoGame>() != null;
    }
}