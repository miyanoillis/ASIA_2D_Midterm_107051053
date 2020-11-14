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
        SceneManager.LoadScene("2DG_menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
