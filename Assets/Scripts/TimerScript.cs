using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    
    float seconds = 180;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        seconds -= Time.deltaTime;

        timerText.text = string.Format("{0}:{1}", (int)(seconds/60), (int)(seconds % 60));

        if (seconds == 0)
        {
            Application.LoadLevel("GameEndScene");
        }
    }
}
