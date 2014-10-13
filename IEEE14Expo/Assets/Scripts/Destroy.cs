using UnityEngine;
using System.Collections;

public class Destroy : Mission
{
		int EnemiesLeft;

		public Destroy (int NumberEnemies, float Difficulty): base(NumberEnemies*10/Difficulty)
		{
				EnemiesLeft = NumberEnemies;

		}
	

}
