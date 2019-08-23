using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velTiro = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velTiro, 0, 0);
    }
}
