using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Volleyball : MonoBehaviour
{
    public ScoreManager scoreManager;
    private Rigidbody rb;
    private int waiting = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SpawnNew();
    }

    private void Update()
    {
        if (waiting == 2) 
        {
            SpawnNew();
            waiting = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Court")
        {
            if(transform.position.z < 0)
            {
                scoreManager.decrement();
            }
            else
            {
                scoreManager.increment();
            }
            StartCoroutine(holdup());
        }
        else if(collision.gameObject.name == "Ground")
        {
            scoreManager.decrement();
            StartCoroutine(holdup());
        }
    }
    private void SpawnNew()
    {
        float x = Random.Range(-11, 11);
        transform.position = new Vector3(x, 2, -7);
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(0, 900 - (scoreManager.getScore() * 10), 0));
    }

    IEnumerator holdup()
    {
        waiting = 1;

        // put animation code here
        yield return new WaitForSeconds(1);

        waiting = 2;
    }
}
