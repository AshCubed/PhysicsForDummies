using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string mainLevelToLoad;

    private void Awake()
    {
        CursorController.instance.ControlCursor(CursorController.CursorState.Unlocked);
    }

    private void Start()
    {
        CursorController.instance.ControlCursor(CursorController.CursorState.Unlocked);
    }

    public void LoadMainLevel()
    {
        FindObjectOfType<FadeCamera>().RedoFade("FadeOut");
        LeanTween.delayedCall(1.8f, () => {
            Debug.Log("load main scene");
            CursorController.instance.ControlCursor(CursorController.CursorState.Locked);
            SceneManager.LoadScene(mainLevelToLoad);
        });
    }

    public void LoadSpecificLevel(string levelName)
    {
        FindObjectOfType<FadeCamera>().RedoFade("FadeOut");
        LeanTween.delayedCall(1.8f, () => {
            Debug.Log("load " + levelName);
            CursorController.instance.ControlCursor(CursorController.CursorState.Locked);
            SceneManager.LoadScene(levelName);
        });
    }

  

    /*public void OpenSettingsMenu()
    {
        LeanTween.moveLocalY(mainMenuPanel, 1090, 1f)
            .setOnStart(() =>
            {
                LeanTween.moveLocalY(settinsPanel, 0, 1f)
                .setOnStart(() => 
                {
                    settinsPanel.SetActive(true);
                });
            });
    }

    public void CloseSettingsMenu()
    {
        LeanTween.moveLocalY(mainMenuPanel, 0, 1f)
            .setOnStart(() =>
            {
                LeanTween.moveLocalY(settinsPanel, -1090, 1f)
                .setOnComplete(() =>
                {
                    settinsPanel.SetActive(false);
                });
            });
    }*/

    public void ApplicationExit()
    {
        Application.Quit();
    }
}
