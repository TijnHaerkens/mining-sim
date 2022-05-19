using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forge : MonoBehaviour
{
    public GameObject lava;
    public GameObject stone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == ("bar"))
        {
            Debug.Log("smelting");
            var block = GameObject.FindWithTag("bar");
            Vector3 appel = new Vector3(collision.transform.position.x + 1f, collision.transform.position.y, collision.transform.position.z);
            Instantiate(lava, appel, transform.rotation);
            Destroy(block);
            
        }
        

    }
}

