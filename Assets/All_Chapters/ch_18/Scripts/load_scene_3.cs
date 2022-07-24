using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class load_scene_3 : MonoBehaviour
{
    public GameObject loadingScreenPanel;
    public Slider progressBar;
    public Text progressText;
    public void LoadScene(string sceneName)
    {
        StartCoroutine(SceneLoadProgress(sceneName));
    }


    IEnumerator SceneLoadProgress(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;
        loadingScreenPanel.SetActive(true);

        while (!operation.isDone)
        {
            //float progress = Mathf.Clamp01(operation.progress) +.1f;
            progressBar.value = (operation.progress + .1f)  * 100;
            progressText.text = "Loading (%" + (progressBar.value) + ")";

            if (operation.progress >= 0.9f)
            {
                Debug.Log("Press the space bar to continue");
                if (Input.GetKeyDown(KeyCode.Space))
                    operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }


}
