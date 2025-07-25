using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Controls;


public class CameraFollow : MonoBehaviour
{
    public Transform cam;
    Transform top;
    Vector3 fark;
    private void Start()
    {
        top = TopController.Instance.transform;
        fark = cam.position - top.position;
    }
    private void Update()
    {
        cam.position = top.position + fark;
    }

}
