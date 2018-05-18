using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

