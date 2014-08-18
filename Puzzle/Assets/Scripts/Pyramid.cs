using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Pyramid
{

    Triangle[] triangles;
    int bottomLevelTriangleCount;
    public Pyramid(int floorCount)
    {
        Triangle.triangles[0] = Resources.Load("FirstTrianglePrefab");
        Triangle.triangles[1] = Resources.Load("SecondTrianglePrefab");
        Triangle.triangles[2] = Resources.Load("ThirdTrianglePrefab");




        constructPyramid(floorCount);
    }

    private void constructPyramid(int floorCount)
    {

        //Todo: since the pyramid behaves a bit like pascal's triangle, we can probably use some kind of maths formula to 
        // a) reduce the size of the triangle array to the actual number of triangles we'll use
        // b) use some kind of formula to figure out neighbors for a triangle. (Think binary trees or heap or w/e where children are at 2x and 2x + 1 index or something like that.
        //The part a) is ez because there's 1 3 5 7 9 ... triangles on the levels of the pyramid.
        //For now we just initialize a rectangular x*y array where it's as high as the level count and wide as the lowest level is
        bottomLevelTriangleCount = floorCount * 2 - 1;
        triangles = new Triangle[bottomLevelTriangleCount * floorCount];

        //Bottom level is index 0
        for(int y = 0; y < floorCount; y++)
        {

            //The first triangle is a special case that needs 3 new lines
            int x = 0;
            int idx = getIndex(x, y); 
            Vector2 position = new Vector2(x,y); //This probably needs some fine tuning since the triangles are more than 1*1 in size
            Color[] lineColors = new Color[3]; //Add some randomized colors (also the implementation within the triangle class is completely unfinished)
            triangles[idx] = new Triangle(TriangleType.First, position, lineColors);

            int thisLevelTriangleCount = (floorCount - y) * 2 - 1;

            x++;
            while(x < thisLevelTriangleCount)
            {
                //Second and third triangle only need 2 new lines
                idx = getIndex(x,y);
                triangles[idx] = new Triangle(TriangleType.Second, position, lineColors); //todo implement updating position and linecolors stuff here
                x++;

                if (x >= thisLevelTriangleCount)
                    break;

                idx = getIndex(x, y);
                triangles[idx] = new Triangle(TriangleType.Third, position, lineColors); //todo implement updating position and linecolros stuff here
                x++;
            }
        }
    }

    private int getIndex(int x, int y)
    {
        return x + y * bottomLevelTriangleCount;
    }
}
