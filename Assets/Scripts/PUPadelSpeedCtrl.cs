using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPadelSpeedCtrl : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D padel;
    public Collider2D padelkiri;
    public Collider2D padelkanan;
   public Collider2D ball;
   public float magnitude;

   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision == ball)
    {
        padel.GetComponent<PadelController>().ActivatePUSpeedUpPadel(magnitude);
        manager.RemovePowerUp(gameObject);
    }
   }
}
