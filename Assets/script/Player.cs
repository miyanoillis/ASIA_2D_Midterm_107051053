using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject end;
    public Text ciontx;
    public int cion;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Particle System Flh")
        {
            end.SetActive(true);
            FindObjectOfType<KID.CharacterMovement2D>().enabled = false;
        }
        if(collision.tag == "cherry")
        {
            Destroy(collision.gameObject);

            cion++;
            ciontx.text = cion + "/999";
        }

    }
}
