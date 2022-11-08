using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float turnSpeed = 0.5f;
    [SerializeField] float driveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -Input.GetAxis("Horizontal") * turnSpeed;
        float moveAmount = Input.GetAxis("Vertical") * driveSpeed;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
}
