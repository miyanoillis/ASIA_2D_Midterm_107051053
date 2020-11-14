using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void start()
    {
        print(0);
        SceneManager.LoadScene("2d_1");
    }
    public void quit()
    {
        print(1);
        Application.Quit();
    }

}
