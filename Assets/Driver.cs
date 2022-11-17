using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    int turnSpeed = 10;
    int driveSpeed = 15;
    int boostSpeed = 30;
    int slowSpeed = 10;

    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        float steerAmount = -Input.GetAxis("Horizontal") * turnSpeed * moveAmount;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        driveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost")
        {
            driveSpeed = boostSpeed;
        }
        else if (other.tag == "Slow")
        {
            driveSpeed = slowSpeed;
        }
    }
}
