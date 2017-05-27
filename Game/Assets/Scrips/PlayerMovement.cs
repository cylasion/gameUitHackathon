using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {

    public GameObject TargetPoint;
    NavMeshAgent Player;

	// Use this for initialization
	void Start () {
        Player = gameObject.GetComponent<NavMeshAgent>();
        TargetPoint.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Ray ray;
            RaycastHit Hit;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out Hit))
            {
                TargetPoint.transform.position = Hit.point;
            }
        }

        Player.SetDestination(TargetPoint.transform.position);
	}
}
