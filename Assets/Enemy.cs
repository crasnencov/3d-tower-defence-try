using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    GameObject target;
    public float speed;
    
    


    void Start()
    {
        target = GameObject.Find("Water Tower");

    }


    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
