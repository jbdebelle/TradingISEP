using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoffFire : MonoBehaviour
{
    [SerializeField]
    public GameObject fire;
    [SerializeField]
    public GameObject redlight;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        bool havefireExtinguisher= GameObject.Find("Player").GetComponent<PlayerControle>().fireoff ;
        Debug.Log("boolfire exting:"+ havefireExtinguisher);
        if (other.tag=="Player"&& Input.GetKey(KeyCode.P) && havefireExtinguisher) {
            Debug.Log("in da loop");
            StartCoroutine(Pause());
            Events.EventFireOff(fire, redlight);

        }
        

    }
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(3f);
    }

}
