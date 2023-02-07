using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burrel : MonoBehaviour
{
    private int count = 0;

    public SpriteRenderer rend;

    private void Start()
    {
        Color tmp = rend.color;
        tmp.a = count;
        rend.color = tmp;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HIT")
        {
            count += 5;
            
            if (count == 100)
            {
                Destroy(gameObject);
            }
            Color tmp = rend.color;
            tmp.a = count / 100f;
            rend.color = tmp;
        }
        
    }
}
