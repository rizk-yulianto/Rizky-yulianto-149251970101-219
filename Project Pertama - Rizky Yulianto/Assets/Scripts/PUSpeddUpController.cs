using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeddUpController : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public float magnitude; 
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }

}
