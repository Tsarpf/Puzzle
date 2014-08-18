﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


class Triangle
{
    public static UnityEngine.Object[] triangles = new UnityEngine.Object[3];

    GameObject go;

    List<GameObject> lines;

    //not sure if line colors should be supplied here, or if the triangle should randomize them by itself etc
    public Triangle(TriangleType type, Vector2 position, Color[] lineColors) 
    {

        //Not sure which is better, this or the other two lines
        go = UnityEngine.Object.Instantiate(triangles[(int)type], position, new Quaternion()) as GameObject;
        //Alternative way to do the thing above
        //go = UnityEngine.Object.Instantiate(triangles[(int)type]) as GameObject;
        //go.transform.position = position;


        //Find lines of this triangle
        lines = new List<GameObject>();
        foreach(Transform child in go.transform)
        {
             if(Enum.IsDefined(typeof(LineNames), child.name)) 
             {
                 lines.Add(child.gameObject);
             }
        }
        //Todo set the colors to the lines we just found
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
