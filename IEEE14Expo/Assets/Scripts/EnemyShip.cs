using UnityEngine;
using System.Collections;
using System;

public class EnemyShip : MonoBehaviour,IDestructible
{
	public float Life {
				get;
				private set;

	}

	public void TakeDamage (float a_damage)
	{
		Life -= a_damage;

		if (Life < 0) 
		{ 
			if (OnDeath != null)
				OnDeath (this, null);

		}
	}

	public event EventHandler OnDeath;

}
