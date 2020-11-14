using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public void next(string Lv)
    {
        SceneManager.LoadScene(Lv);
    }
    public void menu()
    {
        SceneManager.LoadScene("2d_menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
