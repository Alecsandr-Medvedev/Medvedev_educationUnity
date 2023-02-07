using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public GameObject hit;
/*    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(0))
        {
            GameObject hitClone  = Instantiate(hit, Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation);
            Destroy(hitClone, 0.1f);
        }
    }
}
