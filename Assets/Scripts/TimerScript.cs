using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField]
    private int startCountDown = 0;
    [SerializeField]
    Text txtTimer;
    [SerializeField]
    public GameObject fire;
    [SerializeField]
    public GameObject redlight;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while (startCountDown < 600)
        {
            yield return new WaitForSeconds(1f);

            if (startCountDown== 10) {
                Events.EventFire(fire, redlight);
            }
            if (startCountDown == 120) {
                Events.Event2();
            }
            GameObject CameraCanvas = GameObject.Find("CameraCanvas");
            PauseScript pauseScript = CameraCanvas.GetComponent<PauseScript>();
            
            if (pauseScript.PauseMenu.activeInHierarchy)
            {
                
                txtTimer.text = "Temps ecouler :" + startCountDown;
            }
            else
            {
                startCountDown++;
                txtTimer.text = "Temps ecouler :" + startCountDown;
            }
            
            
        }
        
    }
}
