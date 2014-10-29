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

    public Triangle(Vector2 position, UnityEngine.Object prefab) 
    {
        //todo: random orientation (and color?)
        go = UnityEngine.Object.Instantiate(prefab, position, new Quaternion()) as GameObject;

    }
}

