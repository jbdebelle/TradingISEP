using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    [SerializeField]
    static GameObject fire;
    [SerializeField]
    static GameObject redlight;
    // Start is called before the first frame update
    public static void EventFire() 
    {
        fire.SetActive(true);
        redlight.GetComponent<Animator>().enabled = true;
        redlight.GetComponent<AudioSource>().Play();
    }
    public static void Event2()
    {


    }
    public static void Event3()
    {


    }
}
