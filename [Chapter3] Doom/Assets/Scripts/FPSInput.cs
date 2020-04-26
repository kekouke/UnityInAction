using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control script/FPSInput.cs")]

public class FPSInput : MonoBehaviour
{
    public float speed = 6;
    public float gravity = -9.8f;
    private CharacterController charController;
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 movement = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        charController.Move(movement);
    }
}
