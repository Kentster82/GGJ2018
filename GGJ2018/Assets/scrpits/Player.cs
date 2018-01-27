using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    bool usable;
	// Use this for initialization
	void Start () {
        usable = true;
	}/*end of start*/
	
	// Update is called once per frame
	void Update () {
		if (usable == true) /*make sure we want to move the player*/
        {

        }
	}/*end of update*/

    void FixedUpdate()
    {

    }/*end of Fixedupdate*/
}
