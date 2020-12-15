using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update
    public static void EventFire(GameObject fire, GameObject redlight)
    {
        fire.SetActive(true);
        redlight.GetComponent<Animator>().enabled = true;
        redlight.GetComponent<AudioSource>().Play();
    }
    public static void EventFireOff(GameObject fire, GameObject redlight)
    {
        
        fire.SetActive(false);
        redlight.GetComponent<Animator>().enabled = false;
        redlight.GetComponent<AudioSource>().enabled = false;
    }
    public static void Event2()
    {
        Debug.Log("Test pour 2 events");

    }
    public static void Event3()
    {


    }
   
}
