using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainCameraEffect: MonoBehaviour {

    public GameObject GameObj;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            Ray ray;
            RaycastHit Hit;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out Hit))
            {
                if(Hit.transform.tag == "Cube")
                {
                    gameObject.transform.DOMove(new Vector3(Hit.transform.position.x, Hit.transform.position.y + 20, Hit.transform.position.z - Hit.transform.position.z / 2 ), 0.75f);
                }


            }
        }

	}
}
