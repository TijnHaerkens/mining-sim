using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    int x;
    public GameObject bar;
   public Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        Vector3 v3Velocity = RB.velocity;
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == ("pickaxe"))
        {
            x++;
        }
                if(x == 3)
        {
            Debug.Log("mined");
         //   Vector3 appel = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
            Instantiate(bar,transform.position, transform.rotation);
            Destroy(gameObject);
            
        }
       
    }
}