using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int speed;
    private CharacterController playerController;
    private float grivaty = 9.8f;

    private void Awake()
    {
        playerController= GetComponent<CharacterController>();
    }
    private void Update()
    {
        Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * speed * Time.deltaTime;
        Vector3 movementX = Input.GetAxis("Horizontal") * new Vector3(1, 0, 0) * speed * Time.deltaTime;
        Vector3 movement = transform.TransformDirection(movementX + movementZ);
        movement.y -= grivaty;
        playerController.Move(movement);
    }
}
