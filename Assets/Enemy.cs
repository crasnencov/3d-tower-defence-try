using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
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
=======
	public class Enemy : MonoBehaviour
	{

		GameObject target;
		public float speed;
		public float HP;



		void Start()
		{
			target = GameObject.Find("Base");

		}


		void Update()
		{
			// healthBar.value = HP;
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
		}


	}

>>>>>>> d46f500ff4a78c08ab6599d8ced74259b1e5ba31
