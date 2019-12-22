using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCommands : MonoBehaviour {

    public GameObject[] objectsToToggle;
    public GameObject[] topLevelMenus;

	public void PlaySimulation ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        for (int i = 0; i < objectsToToggle.Length; i++)
        {
            ToggleObjectActive(objectsToToggle[i]);
        }

        GlobalVar.SetInGame(true);
	}

    public void StopSimulation() {
        SceneManager.LoadScene(0);

        for (int i = 0; i < objectsToToggle.Length; i++)
        {
            ToggleObjectActive(objectsToToggle[i]);
        }

        GlobalVar.SetInGame(false);
    }

    public void ToggleObjectActive(GameObject objectToToggle) {
        objectToToggle.SetActive(!objectToToggle.activeInHierarchy);
    }


    public void OnBackButtonClick() {
        if (GlobalVar.getInGame() == false)
        {
            topLevelMenus[0].SetActive(true);
        }
        else
        {
            topLevelMenus[1].SetActive(true);
        }

    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
