using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;



    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
