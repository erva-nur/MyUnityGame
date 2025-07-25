using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;

public class OyunBitirici : MonoBehaviour
{

    
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player kap�ya �arpt�, sahne de�i�tirilecek");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    
}
