using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    float Power;
    public float minPower = 0f;
    public float maxPower = 100f;
    List<Rigidbody> ballList;
    bool ballReady;
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ballList.Count > 0)
        {
            ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if (Power <= maxPower)
                    Power += 1000 * Time.deltaTime;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody r in ballList)
                {
                    r.AddForce(Power * Vector3.forward);
                }
            }
        }
        else
        {
            ballReady = false;
            Power = 0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            Power = 0f;
        }
    }
}
