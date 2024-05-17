using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;

   private Rigidbody2D rig; 
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
        rig.velocity = speed; 
    }

    // Update is called once per frame
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);

    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
