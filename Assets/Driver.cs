using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    int turnSpeed = 10;
    int driveSpeed = 15;

    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        float steerAmount = -Input.GetAxis("Horizontal") * turnSpeed * moveAmount;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
}
