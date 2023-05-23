using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float speed;
    [SerializeField] private UIManager _uiManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletPref = Instantiate(bullet, transform.position + transform.forward * 3, transform.rotation);
            Rigidbody rb = bulletPref.GetComponent<Rigidbody>();
            bulletPref.GetComponent<Bullet>().uiManager = _uiManager;
            if (rb == null)
            {
                rb = bulletPref.AddComponent<Rigidbody>();
                rb.useGravity = false;
            }
            rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);
            Destroy(bulletPref, 10f);
        }
    }
}
