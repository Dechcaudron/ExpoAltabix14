using UnityEngine;
using System.Collections;
using System.Timers;

public abstract class Mission
{
		Timer CountDown;

		public Mission (double MissionTime)
		{
				CountDown = new Timer (MissionTime);
				CountDown.Elapsed += missiontimeup;
				CountDown.Start ();
		}

		void missiontimeup (object sender, ElapsedEventArgs e)
		{
				Debug.Log ("MissionTimeUp");
		}
}
