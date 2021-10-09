using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static event Action collide;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "spike")
        {
          PlayerHealth.Instance.SubHealth(1); //lose health for hitting spike
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy") //observer pattern bellow
        {
            #region observer
            collide.Invoke();
            #endregion
        }
    }

}
