using UnityEngine;
using UnityEngine.VR;

public class ToggleVR : MonoBehaviour
{
	public void Start()
	{
		VRSettings.enabled = true;
		Debug.Log("Changed VRSettings.enabled to:"+VRSettings.enabled);
	}

	//Example of toggling VRSettings
	private void Update ()
	{
		//If V is pressed, toggle VRSettings.enabled
		if (Input.GetKeyDown(KeyCode.V))
		{
			VRSettings.enabled = !VRSettings.enabled;
			Debug.Log("Changed VRSettings.enabled to:"+VRSettings.enabled);
		}	
	}
}