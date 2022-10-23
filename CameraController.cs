using System.Security.Cryptography;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 newof1 = new Vector3(0, 5, -7);
    private Vector3 newof2 = new Vector3(0, 2.5f, 0);
    public Camera MCam;
    public Camera cam;
    public GameObject Car;

    void LateUpdate()
    {
        if (MCam.enabled == true)
        {
            MCam.transform.position = Car.transform.position + newof1;
        }
        if (cam.enabled == true)
        {
            cam.transform.position = Car.transform.position + newof2;
        }
    }
}
