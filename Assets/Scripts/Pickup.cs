using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject SFXPikcupObj;
   
    //Called when this object with a collider/rigidbody has begun touching another collider/rigidbody
    //One of the colliders is a trigger and has a rigidbody
    private void OnTriggerEnter(Collider other)
    {
        SFXPikcupObj.GetComponent<AudioSource>().Play();
        //Pickup_SFX.Play();
        other.transform.localScale += Vector3.one * 0.6f;
        Destroy(gameObject);
    }
}
