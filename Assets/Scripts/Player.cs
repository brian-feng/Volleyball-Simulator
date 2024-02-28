using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Volleyball volleyball;
    private float idealDistance = 4.5f;
    private float maxPower = 50;
    private bool waiting;

    IEnumerator Cooldown()
    {
        waiting = true;

        // put animation code here
        yield return new WaitForSeconds(1);

        waiting = false;
    }
    private void HitBall()
    {
        if (!waiting)
        {
            StartCoroutine(Cooldown());
            float power = GetPower();
            if (power > 0)
            {
                Rigidbody rb = volleyball.GetComponent<Rigidbody>();
                rb.velocity = GetReflection() * power;
            }
        }
    }
    private Vector3 GetReflection()
    {
        // Math from https://www.youtube.com/watch?v=bsLFIPoBPEQ
        Vector3 volleyballVector = transform.position - volleyball.transform.position;
        Vector3 planeTangent = Vector3.Cross(volleyballVector, -1 * Camera.main.transform.forward);
        Vector3 planeNormal = Vector3.Cross(planeTangent, volleyballVector);
        Vector3 reflected = Vector3.Reflect(-1 * Camera.main.transform.forward, planeNormal);
        return reflected.normalized;
    }
    private float GetPower()
    {
        float x = Vector3.Distance(volleyball.transform.position, transform.position);
        float y = -Mathf.Abs(x - idealDistance)/3 + 1;
        float power = y * maxPower;
        power = Mathf.Clamp(power, 0, maxPower);
        return power;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HitBall();
        }
    }
}
