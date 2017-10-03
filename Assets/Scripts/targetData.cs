using UnityEngine;
using UnityEngine.UI;
using System.Collections; 
using System.Collections.Generic; 

namespace Vuforia  {

	public class targetData : MonoBehaviour {

		public Transform ButtonAction1;
		public Transform ButtonAction2;
		public Transform ButtonAction3;
		public Transform ButtonAction4;
		public Transform ButtonAction5;
		public Transform ButtonAction6;
		public Transform ButtonAction7;
		public Transform ButtonAction8;
		public Transform ButtonAction9;
		public Transform ButtonAction10;
		public Transform ButtonAction11;
		public Transform ButtonAction12;
		public Transform ButtonAction13;
		public Transform ButtonAction14;
		public Transform ButtonAction15;
		public Transform ButtonAction16;
		public Transform ButtonAction17;
		public Transform ButtonAction18;
		public Transform ButtonAction19;
		public Transform ButtonAction20;
		public Transform ButtonAction21;
		public Transform ButtonAction22;
		public Transform ButtonAction23;
		public Transform ButtonAction24;
		public Transform ButtonAction25;
		public Transform ButtonAction26;
		public Transform ButtonAction27;
		public Transform ButtonAction28;
		public Transform ButtonAction29;
		public Transform ButtonAction30;
		public Transform ButtonAction31;
		public Transform ButtonAction32;
		public Transform ButtonAction33;
		public Transform ButtonAction34;
		public Transform ButtonAction35;
		public Transform ButtonAction36;
		public Transform ButtonAction37;
		public Transform ButtonAction38;
		public Transform ButtonAction39;
		public Transform ButtonAction40;
		// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
			StateManager sm = TrackerManager.Instance.GetStateManager(); 
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours(); 
			foreach (TrackableBehaviour tb in tbs) { 

				ButtonAction1.gameObject.SetActive(true);
				ButtonAction2.gameObject.SetActive(true);
				ButtonAction3.gameObject.SetActive(true);
				ButtonAction4.gameObject.SetActive(true);
				ButtonAction5.gameObject.SetActive(true);
				ButtonAction6.gameObject.SetActive(true);
				ButtonAction7.gameObject.SetActive(true);
				ButtonAction8.gameObject.SetActive(true);
				ButtonAction9.gameObject.SetActive(true);
				ButtonAction10.gameObject.SetActive(true);
				ButtonAction11.gameObject.SetActive(true);
				ButtonAction12.gameObject.SetActive(true);
				ButtonAction13.gameObject.SetActive(true);
				ButtonAction14.gameObject.SetActive(true);
				ButtonAction15.gameObject.SetActive(true);
				ButtonAction16.gameObject.SetActive(true);
				ButtonAction17.gameObject.SetActive(true);
				ButtonAction18.gameObject.SetActive(true);
				ButtonAction19.gameObject.SetActive(true);
				ButtonAction21.gameObject.SetActive(true);
				ButtonAction22.gameObject.SetActive(true);
				ButtonAction23.gameObject.SetActive(true);
				ButtonAction24.gameObject.SetActive(true);
				ButtonAction25.gameObject.SetActive(true);
				ButtonAction26.gameObject.SetActive(true);
				ButtonAction27.gameObject.SetActive(true);
				ButtonAction28.gameObject.SetActive(true);
				ButtonAction29.gameObject.SetActive(true);
				ButtonAction30.gameObject.SetActive(true);
				ButtonAction31.gameObject.SetActive(true);
				ButtonAction32.gameObject.SetActive(true);
				ButtonAction33.gameObject.SetActive(true);
				ButtonAction34.gameObject.SetActive(true);
				ButtonAction35.gameObject.SetActive(true);
				ButtonAction36.gameObject.SetActive(true);
				ButtonAction37.gameObject.SetActive(true);
				ButtonAction38.gameObject.SetActive(true);
				ButtonAction39.gameObject.SetActive(true);
				ButtonAction40.gameObject.SetActive(true);

			}
		
	}
}
}
