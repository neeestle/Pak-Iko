using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject,0.5f);
    }
}
