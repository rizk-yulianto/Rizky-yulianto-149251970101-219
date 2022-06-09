using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D Bola;
    public bool isRight;
    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Bola)
            Debug.Log("Detected Collision");
        {
            if (isRight)
            {
                manager.AddRightScore(1);
                Debug.Log("GOl Kanan");
            }
            else
            {
                manager.AddLeftScore(1);
                Debug.Log("Gol Kiri");
            }
        }
    }
}
