using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void start()
    {
        print(0);
        SceneManager.LoadScene("2DG");
    }
    public void quit()
    {
        print(1);
        Application.Quit();
    }

}
