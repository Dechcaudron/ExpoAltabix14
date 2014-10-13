using UnityEngine;
using System.Collections;
using System;

public interface IDestructible
{ 
	float Life {
				get; 
	}

	void TakeDamage(float a_damage);


	event EventHandler OnDeath;
}
