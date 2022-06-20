using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sell : MonoBehaviour
{
    public double money = 0;
    public GameObject steen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (money >= 3)
        {
            Vector3 appel = new Vector3(transform.position.x + 10f, transform.position.y - 1.46f,transform.position.z);
            Instantiate(steen, appel, transform.rotation);
            money -= 0.5f;
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == ("mold"))
        {
            money += 1;
            Debug.Log("smelting");
            var block = GameObject.FindWithTag("mold");
           
            Destroy(block);

         
        }


    }
}
