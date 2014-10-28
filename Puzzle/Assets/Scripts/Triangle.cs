using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


class Triangle
{
    public static UnityEngine.Object triangle = new UnityEngine.Object();

    GameObject go;

    //List<GameObject> lines;

    Triangle rightChild;
    Triangle leftChild;

    //not sure if line colors should be supplied here, or if the triangle should randomize them by itself etc
    public Triangle(Vector2 position) 
    {

        //Not sure which is better, this or the other two lines
        go = UnityEngine.Object.Instantiate(triangle, position, new Quaternion()) as GameObject;
        //Alternative way to do the thing above
        //go = UnityEngine.Object.Instantiate(triangles[(int)type]) as GameObject;
        //go.transform.position = position;

    }
}

enum LineNames
{
    up,
    right,
    left,
    down
}

enum TriangleType
{
    First,
    Second,
    Third
}
