using UnityEngine;
using UnityEngine.VR;

public class ToggleVR : MonoBehaviour
{
	public void Start()
	{
		VRSettings.enabled = true;
		Debug.Log("Changed VRSettings.enabled to:"+VRSettings.enabled);
	}

	void OnGUI()
	{
		if( GUILayout.Button( "Toggle VR", GUILayout.Width( 300 ), GUILayout.Height( 100 ) ) )
		{
			Toggle();
		}
	}


	//Example of toggling VRSettings
	private void Update ()
	{
		//If V is pressed, toggle VRSettings.enabled
		if (Input.GetKeyDown(KeyCode.V))
		{
			Toggle();
			Debug.Log("Changed VRSettings.enabled to:"+VRSettings.enabled);
		}	
	}

	void Toggle() {
		VRSettings.enabled = !VRSettings.enabled;
	}
}