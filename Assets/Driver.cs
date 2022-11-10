using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    int turnSpeed = 10;
    int driveSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        float steerAmount = -Input.GetAxis("Horizontal") * turnSpeed * moveAmount;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
}
