using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Controls;

public class GoldRotater : MonoBehaviour
{
    public float donmeHizi;
    void Start()
    {
        
    }

    
    void Update()
    {
        Quaternion rot = Quaternion.Euler(0, transform.rotation.eulerAngles.y+(1*donmeHizi),90);
        transform.rotation = rot;
    }
}
