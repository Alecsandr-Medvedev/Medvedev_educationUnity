using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private HingeJoint2D joint;
   
    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            joint.enabled = false;
        }
    }
}
