using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings(bool active)
    {
        mainMenuPanel.SetActive(!active);
        settingsPanel.SetActive(active);
    }
}
