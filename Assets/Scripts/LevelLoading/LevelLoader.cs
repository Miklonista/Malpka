using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class LevelLoader : MonoBehaviour
    {
        //[SerializeField]
        //private Animator levelLoaderAnimator;
        
        [SerializeField]
        private string sceneName;

        string CROSSFADE_START = "Crossfade_Start";
        string CROSSFADE_END = "Crossfade_End";
        
        public void LoadScene()
        {
            StartCoroutine(LoadLevel());
        }

        protected virtual IEnumerator LoadLevel()
        {
            //levelLoaderAnimator.Play(CROSSFADE_START);

            //yield return new WaitForSeconds(1f);

            //levelLoaderAnimator.Play(CROSSFADE_END);

            SceneManager.LoadScene(sceneName);
            yield break;
        }
    }
