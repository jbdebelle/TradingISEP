using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f,rot= 80f, curspeed;

    [SerializeField]
    GameObject ImageGameOver;
    // Update is called once per frame
    void FixedUpdate()
    {
        
        
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
