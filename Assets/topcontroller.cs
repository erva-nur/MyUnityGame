using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class TopController : MonoBehaviour
{
    public static TopController Instance;
    private void Awake()   // Start'tan önce çalýþýr
    {
        Instance = this;
    }

    public GameObject Kapi;            // Çýkýþ kapýsý
    public GameObject oyunBittiYazisi; // "Oyun Bitti" yazýsý (Canvas içindeki Text)
    public Rigidbody rb;
    public TMP_Text skorYazisi;
    Vector2 girdi;
    public float speed;
    public float ziplamaGucu;
    public bool zemindeMi;
    int skor = 0;

    void Start()
    {
        // Oyun baþlarken "Oyun Bitti" yazýsý görünmesin
        oyunBittiYazisi.SetActive(false);
    }

    void Update()
    {
        girdi.x = Input.GetAxis("Horizontal");
        girdi.y = Input.GetAxis("Vertical");
        girdi = girdi * speed;

        Vector3 v = rb.velocity;  // linearVelocity deðil, velocity kullanmak daha doðru
        v.x = girdi.x;
        v.z = girdi.y;
        rb.velocity = v;

        if (Input.GetKeyDown(KeyCode.Space) && zemindeMi)
        {
            Zipla();
        }
    }

    void Zipla()
    {
        rb.AddForce(Vector3.up * ziplamaGucu, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OyunBitirici"))
        {
            Debug.Log("Oyun bitti tetiklendi (Collision)!");
            oyunBittiYazisi.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Zemin"))  // Eðer zemine temas varsa
        {
            zemindeMi = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            zemindeMi = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gold"))
        {
            skor++;
            skorYazisi.text = "SKOR: " + skor;
            other.gameObject.SetActive(false);

            if (skor > 9)
            {
                Kapi.SetActive(true); // Kapýyý aç
            }
        }
    }
}