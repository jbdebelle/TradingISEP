using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherS : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerControle>().fireoff = true;
            GetComponent<MeshRenderer>().enabled = false;
            
            GetComponent<BoxCollider>().enabled = false;
            Destroy(transform.gameObject, 1f);
        }
    }
    
}
