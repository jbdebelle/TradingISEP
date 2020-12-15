using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControle : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f,rot= 80f, curspeed;
    [SerializeField]
    public bool fireoff = false;

    [SerializeField]
    public GameObject fumer;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (fireoff && Input.GetKey(KeyCode.P))
        {
            
            fumer.SetActive(true);


        }
        else
        {

            fumer.SetActive(false);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            curspeed = speed * 2;
        }
        else 
        {
            curspeed = speed ;
        }
        transform.Rotate(Vector3.up * rot* Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curspeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }
   
}
