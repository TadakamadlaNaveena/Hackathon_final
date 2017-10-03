/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
        #region PRIVATE_MEMBER_VARIABLES

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


 
        private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
        }


        private void OnTrackingLost()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");

			ButtonAction1.gameObject.SetActive(false);
			ButtonAction2.gameObject.SetActive(false);
			ButtonAction3.gameObject.SetActive(false);
			ButtonAction4.gameObject.SetActive(false);
			ButtonAction5.gameObject.SetActive(false);
			ButtonAction6.gameObject.SetActive(false);
			ButtonAction7.gameObject.SetActive(false);
			ButtonAction8.gameObject.SetActive(false);
			ButtonAction9.gameObject.SetActive(false);
			ButtonAction10.gameObject.SetActive(false);
			ButtonAction11.gameObject.SetActive(false);
			ButtonAction12.gameObject.SetActive(false);
			ButtonAction13.gameObject.SetActive(false);
			ButtonAction14.gameObject.SetActive(false);
			ButtonAction15.gameObject.SetActive(false);
			ButtonAction16.gameObject.SetActive(false);
			ButtonAction17.gameObject.SetActive(false);
			ButtonAction18.gameObject.SetActive(false);
			ButtonAction19.gameObject.SetActive(false);
			ButtonAction20.gameObject.SetActive(false);
			ButtonAction21.gameObject.SetActive(false);
			ButtonAction22.gameObject.SetActive(false);
			ButtonAction23.gameObject.SetActive(false);
			ButtonAction24.gameObject.SetActive(false);
			ButtonAction25.gameObject.SetActive(false);
			ButtonAction26.gameObject.SetActive(false);
			ButtonAction27.gameObject.SetActive(false);
			ButtonAction28.gameObject.SetActive(false);
			ButtonAction29.gameObject.SetActive(false);
			ButtonAction30.gameObject.SetActive(false);
			ButtonAction31.gameObject.SetActive(false);
			ButtonAction32.gameObject.SetActive(false);
			ButtonAction33.gameObject.SetActive(false);
			ButtonAction34.gameObject.SetActive(false);
			ButtonAction35.gameObject.SetActive(false);
			ButtonAction36.gameObject.SetActive(false);
			ButtonAction37.gameObject.SetActive(false);
			ButtonAction38.gameObject.SetActive(false);
			ButtonAction39.gameObject.SetActive(false);
			ButtonAction40.gameObject.SetActive(false);
        }

        #endregion // PRIVATE_METHODS
    }
}
