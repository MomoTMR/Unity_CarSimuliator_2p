using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject CurrentCar;
    private float _turnespeed = 45.0f;
    private float _speed = 10.0f;
    private float horizontalInput = 1.0f;
    private float forwardInput = 1.0f;


    // Update is called once per frame


    void FixedUpdate()
    {
        if (CurrentCar == GameObject.Find("Player1"))
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
        }
        if (CurrentCar == GameObject.Find("Player2"))
        {
            horizontalInput = Input.GetAxis("Horizontal2");
            forwardInput = Input.GetAxis("Vertical2");
        }
        CurrentCar.transform.Translate(Vector3.forward * Time.deltaTime * _speed * forwardInput);
        CurrentCar.transform.Rotate(Vector3.up * Time.deltaTime * _turnespeed * horizontalInput);
    }
}
