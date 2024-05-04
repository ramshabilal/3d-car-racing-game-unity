using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    public void loadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1.0f;
        } else {
            Time.timeScale = 1f;
        }
    }

    IEnumerator LoadAsynchronously(int sceneIndex){
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while(!operation.isDone) {
            float progress = Mathf.Clamp01 (operation.progress / .9f);
            slider.value = progress;
            progressText.text= progress*100f + "%";
            yield return null;
        }
    }

    public void QuitApplicationFun() {
        Application.Quit();
    }
}
