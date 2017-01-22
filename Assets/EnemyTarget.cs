using UnityEngine;
using System.Collections;

/*
 * When player looks to EnemyTarget, lockOn value increases
 * When lockOn value == lockOnMax, target is locked
 * 
 * If target is not locked and player is not looking, lockOn value drops to 0
 *
 * If lockOn value not 0, show 2D UI to show lockOn value
 *
 */
public class EnemyTarget : MonoBehaviour {

	int lockOnValue = 0;
	int lockOnMax = 100;
	bool locked = false;

	bool lookedAt = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (lookedAt && lockOnValue <= lockOnMax) {
			lockOnValue += 1;
		}
		if (!lookedAt && !locked) {
			lockOnValue -= 1;
		}

		if (lockOnValue >= lockOnMax) {
			locked = true;
		}

		lookedAt = false;
	}

	void AimedAt() {
		lookedAt = true;
	}

}
