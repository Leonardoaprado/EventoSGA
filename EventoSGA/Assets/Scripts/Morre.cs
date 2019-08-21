using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morre : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject)
        {
            Destroy(other.gameObject);
        }

    }
}
