using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    [HideInInspector] public UIManager uiManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Green"))
        {
            uiManager.pointCount += 5;
        }
        if (other.CompareTag("Yellow"))
        {
            uiManager.pointCount -= 10;
        }
        if (other.CompareTag("White"))
        {
            uiManager.timerCount += 5;
        }
        if (other.CompareTag("Reload"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
