using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 12, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < transform.position.x)
        {
            transform.position = new Vector3(transform.position.x - 0.02f, 12, 0);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + 0.02f, 12, 0);
        }
    }
}
