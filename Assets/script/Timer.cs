using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float hourcount;
    public float minuteCount;
    public float secondsCount;
    public bool Stop = false;

    void Update()
    {
        if (Stop == true)
            return;
        if (Stop == false)
            UpdateTimerUI();
    }
    public void UpdateTimerUI()
    {
        secondsCount -= Time.smoothDeltaTime * 1;
        timerText.text = string.Format("{0:00}:{1:00}.{2:00}", hourcount, minuteCount, secondsCount);

        if (secondsCount < -0.9f)
        {
            minuteCount--;
            secondsCount = 59;
        }
        else if (minuteCount <= -1)
        {
            hourcount--;
            minuteCount = 59;
        }
        else if (hourcount <= -1)
        {
            minuteCount = 59;
        }
        else if (hourcount <= 0 & minuteCount <= 0 & secondsCount <= -1)
        {
            Stop = true;
            return;
        }
    }
}