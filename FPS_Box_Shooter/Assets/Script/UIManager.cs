using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private TextMeshProUGUI timer;
    public float timerCount;

    [Header("Point")]
    [SerializeField] private TextMeshProUGUI point;
    public float pointCount;

    [Header("Timer")]
    [SerializeField] private GameObject EndObject;
    private bool timerGo = true;
    private void Update()
    {
        if (timerGo)   
            timerCount -= Time.deltaTime;
        timer.text = timerCount.ToString("0.00");

        point.text = pointCount.ToString();
        Timer();
    }

    private void Timer()
    {
        if (timerCount <= 0)
        {
            EndObject.SetActive(true);
            timerGo = false;
        }
    }
}
