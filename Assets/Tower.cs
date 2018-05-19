using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    Transform turretTransform;


    void Start()
    {
        turretTransform = transform.Find("Turret");
        Debug.Log(turretTransform);
    }

    void Update()
    {
        Enemy[] enemies = GameObject.FindObjectsOfType<Enemy>();

        Enemy nearestEnemy = null;
        float dist = Mathf.Infinity;

        foreach (Enemy e in enemies)
        {
            float d = Vector3.Distance(transform.position, e.transform.position);//distance between enemy and turret

            if (nearestEnemy == null || d < dist)
            {
                nearestEnemy = e;
                dist = d;
            }
        }
        if (nearestEnemy == null)
        {
            Debug.Log("no enemies");
            return;
        }

        Vector3 dir = nearestEnemy.transform.position - transform.position;// vector direction from the turret to the target
        Quaternion lookRot = Quaternion.LookRotation(dir);//?
        Debug.Log(lookRot.eulerAngles);


        turretTransform.rotation = Quaternion.Euler(-90, lookRot.eulerAngles.y, 0);

    }
}
