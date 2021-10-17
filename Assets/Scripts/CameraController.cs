using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform target;

	void LateUpdate()
	{
		// si la position du player est sup a la position de la camera alors on change la position
		if (target.position.y > transform.position.y)
		{
			transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
		}
	}
}
