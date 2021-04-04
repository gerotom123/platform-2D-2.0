using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemykill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 3));
            Destroy(transform.parent.gameObject);
        }
    }
}
