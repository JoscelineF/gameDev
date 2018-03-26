using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	void Update () 
	{
		transform.Rotate (new Vector3 (45, 30, 15) * Time.deltaTime);
	}
}