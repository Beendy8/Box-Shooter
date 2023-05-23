using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndObjectRotati : MonoBehaviour
{
    [SerializeField] private float speedRotation;

    private void Update()
    {
        transform.Rotate(Vector3.up * speedRotation * Time.deltaTime);
    }
}
