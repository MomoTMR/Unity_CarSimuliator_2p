using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    private Camera MCam1;
    private Camera cam1;
    private Camera MCam2;
    private Camera cam2;
    // Start is called before the first frame update
    private void Start()
    {
        MCam1 = GameObject.Find("Cam1p").GetComponent<Camera>();
        MCam2 = GameObject.Find("Cam2p").GetComponent<Camera>();
        cam1 = GameObject.Find("CamB").GetComponent<Camera>();
        cam2 = GameObject.Find("CamB2").GetComponent<Camera>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            MCam1.enabled = !MCam1.enabled;
            cam1.enabled = !cam1.enabled;
            return;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            MCam2.enabled = !MCam2.enabled;
            cam2.enabled = !cam2.enabled;
            return;
        }
    }
}
