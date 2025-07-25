using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Kontrolcu:MonoBehaviour
{
    insan ahmet;
    insan mehmet;
    void Start()
    {
        ahmet = new insan(19,"ahmet yilmaz");
        mehmet = new insan(43, "mehmet asd");
        
        Debug.Log(ahmet.yas);
        Debug.Log(mehmet.yas);
        Debug.Log(ahmet.isim);
        Debug.Log(mehmet.isim);
    }
}
