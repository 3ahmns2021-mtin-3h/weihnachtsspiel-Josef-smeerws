using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    int countCollisions = 0;
    public bool carringNut = false;
    public int points = 0;
    public GameObject feedbackJosefNut;
    public TextMeshProUGUI scoreDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Cat"))
        {
            if (carringNut)
            {
                carringNut = false;
                feedbackJosefNut.SetActive(carringNut);
            }
        }
        else if(collision.name.Contains("Bird"))
        {
            if (carringNut)
            {
                carringNut = false;
                feedbackJosefNut.SetActive(carringNut);
            }
        }
        else if (collision.name.Contains("Nut") && !carringNut)
        {
            Destroy(collision.gameObject);
            carringNut = true;
            feedbackJosefNut.SetActive(true);
        }
        else if (collision.name == "Nest")
        {
            if (carringNut)
            {
                carringNut = false;
                points++;
                feedbackJosefNut.SetActive(false);
                scoreDisplay.text = points.ToString();
            }
        }
        

        Debug.Log("count Collisions " + countCollisions);
        Debug.Log("In Player, collide with " + collision);
    }
}
