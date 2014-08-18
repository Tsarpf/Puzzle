using UnityEngine;
using System.Collections;

public class Initializer : MonoBehaviour {

    Object line;
    Triangle[][] pyramid;
	// Use this for initialization
	void Start () {
        Triangle.triangles[0] = Resources.Load("FirstTrianglePrefab");
        Triangle.triangles[1] = Resources.Load("SecondTrianglePrefab");
        Triangle.triangles[2] = Resources.Load("ThirdTrianglePrefab");


	}

    void constructPyramid(int floorCount)
    {
        int bottomLevelTriangleCount = floorCount * 2 - 1;
        
        pyramid = new Triangle[bottomLevelTriangleCount][];

        //Bottom level is index 0
        for(int y = 0; y < floorCount; y++)
        {
           for(int x = 0; x < y * 2 - 1; x++)
           {

           }
        }
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
