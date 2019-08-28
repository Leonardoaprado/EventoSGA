using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class ApagaFogo : MonoBehaviour
{
    public GameObject player;
    public GameObject TiroAgua;
   



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "TiroAgua")
        {
            Destroy(this.gameObject);
            Destroy(this.TiroAgua);

        }
        if (other.gameObject == player)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
