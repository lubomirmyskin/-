using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Missile : MonoBehaviour
{
    int speed = 5;

    void Start()
    {
        Destroy(gameObject, 3);
    }
    public void Update()
    {
            transform.position +=
            transform.forward *
            speed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    public void OnTriggerEnter()
    {
        Destroy(gameObject);
    }

    


}
