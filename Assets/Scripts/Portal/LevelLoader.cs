using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
    {
        [SerializeField]
        private Animator levelLoaderAnimator;

        string CROSSFADE_START = "Crossfade_Start";
        string CROSSFADE_END = "Crossfade_End";
        
        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadLevel(sceneName));
        }

        IEnumerator LoadLevel(string sceneName)
        {
            levelLoaderAnimator.Play(CROSSFADE_START);

            yield return new WaitForSeconds(1f);

            levelLoaderAnimator.Play(CROSSFADE_END);

            SceneManager.LoadScene(sceneName);
        }
    }
