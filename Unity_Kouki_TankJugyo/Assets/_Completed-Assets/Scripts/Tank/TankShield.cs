using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShield : MonoBehaviour {
    public GameObject shield;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButton("Shield1"))
        {
            shield.SetActive(true);
        }
        else
        {
            shield.SetActive(false);
        }
	}

    public bool IsShield()
    {
        return Input.GetButton("Shield1");
    }
}
