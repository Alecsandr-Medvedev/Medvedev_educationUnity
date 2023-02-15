using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int _power;

    [SerializeField] private Camera _cam;

    private HingeJoint2D joint;
    private Rigidbody2D rig;

    private double onRope;
   
    void Start()
    {
        onRope = 0;
        joint = GetComponent<HingeJoint2D>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _cam.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        if (onRope != 0)
        {
            onRope -= Time.deltaTime * 1;
        }
        if (Input.GetMouseButtonDown(0))
        {
            joint.enabled = false;
            onRope = 1;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rope")
        {
            if (onRope != 0 && !joint.enabled)
            {
                joint.connectedBody = collision.GetComponent<Rigidbody2D>();
                joint.enabled = true;
            }
        }
    }
}
