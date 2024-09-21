using TMPro;
using UnityEngine;
using UnityEngine.UI; 

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText; 
    private float timer = 0f; 

    void Update()
    {
        
        timer += Time.deltaTime;
        if(timerText != null) timerText.text = Mathf.FloorToInt(timer).ToString();

    }
}