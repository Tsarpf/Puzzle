using UnityEngine;
using System.Collections;

public class Initializer : MonoBehaviour {
	// Use this for initializationo

    Pyramid pyramid;

	void Start ()
    {
        pyramid = new Pyramid(5);
	}
	
	// Update is called once per frame
	void Update () 
    {
        pyramid.checkGaps();
	}
}
