using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int _power;

    private HingeJoint2D joint;
    private Rigidbody2D rig;
   
    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            joint.enabled = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddRelativeForce(new Vector2(-_power, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddRelativeForce(new Vector2(_power, 0));
        }
    }
}
