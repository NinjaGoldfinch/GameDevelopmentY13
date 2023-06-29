using System;
using UnityEngine;

public class ObjectPickup : MonoBehaviour
{
    public event Action<int> OnCollectKey;
    
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.tag == "Player") {
            Debug.Log("E");
        }
    }
}
