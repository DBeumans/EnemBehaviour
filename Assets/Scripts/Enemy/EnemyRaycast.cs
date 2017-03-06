using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRaycast : MonoBehaviour {

	private EnemyMovement myEnemyMovement;

	[SerializeField] private float myRange;

	private void Start () {
		myEnemyMovement = GetComponent<EnemyMovement> ();
	}

	private void Update () {
		raycast ();
	}

	private void raycast()
	{
		RaycastHit hit;
		float dist;

		Collider[] objs;

		objs = Physics.OverlapSphere (transform.position + Vector3.up, myRange);

		foreach (Collider c in objs) {
			if (c.name != this.transform.name) {
				Debug.Log (c.name);
			}
		}
	}
}
