using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour {
    public SteamVR_TrackedObject mTrackedObject;
    public SteamVR_Controller.Device mDevice;

    private void Awake()
    {
        mTrackedObject = GetComponent<SteamVR_TrackedObject>();
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        mDevice = SteamVR_Controller.Input((int)mTrackedObject.index);
        Vector2 triggerVal = mDevice.GetAxis(EVRButtonId.k_EButton_SteamVR_Trigger);
        #region Trigger
        if (mDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Trigger Down");
        }
        if (mDevice.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Trigger Up");
        }

        
        #endregion

    }
}
