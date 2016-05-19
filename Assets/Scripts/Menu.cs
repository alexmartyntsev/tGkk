using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void LoadOnClick(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame(bool exit)
    {
        if (exit)
            Application.Quit();
    }
}
