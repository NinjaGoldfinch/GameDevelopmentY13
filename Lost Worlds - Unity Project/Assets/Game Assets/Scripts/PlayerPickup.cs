using System;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public event Action<int> OnCollectKey;
    
    private void OnTriggerEnter(Collider other)
    {   
        Debug.Log("Failed");
        PlayerCollectable collectable = other.gameObject.GetComponent<PlayerCollectable>();
        if (collectable != null)
        {
            Debug.Log("Failed");
            if (collectable is Key)
            {
                Key key = collectable as Key;
                int keyValue = key.KeyValue;
                GameObject.Destroy(collectable.gameObject);
                Debug.Log($"Picked up key");
                OnCollectKey?.Invoke(keyValue);
            }
        }
    }
}
