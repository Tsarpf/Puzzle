using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Pyramid
{

    Triangle[] triangles;
    Object trianglePrefab;

    Gap[] gaps;

    public Pyramid(int floorCount)
    {
        trianglePrefab = Resources.Load("trianglePrefab");

        constructPyramid(floorCount);
    }

    private void constructPyramid(int floorCount)
    {

        //Todo: since the pyramid behaves a bit like pascal's triangle, we can probably use some kind of maths formula to 
        // a) reduce the size of the triangle array to the actual number of triangles we'll use
        // b) use some kind of formula to figure out neighbors for a triangle. (Think binary trees or heap or w/e where children are at 2x and 2x + 1 index or something like that.
        //The part a) is ez because there's 1 3 5 7 9 ... triangles on the levels of the pyramid.
        //For now we just initialize a rectangular x*y array where it's as high as the level count and wide as the lowest level is

        triangles = new Triangle[floorCount*(floorCount+1) / 2];
        int triangleBaseLength = 10;
        float triangleHeight = triangleBaseLength * 3 / 4;
        float center = 10;
        Vector2 position = new Vector2(center, center);
        //building from top down
        int idx = 0;

        for(int y = 1; y <= floorCount; y++)        //create triangles
        {
            position = new Vector2(center - triangleBaseLength * (y - 1) - (y % 2) * (triangleBaseLength / 2), position.y - triangleHeight);
            for (int x = 0; x < y; x++)
            {
                triangles[idx] = new Triangle(position);
                idx ++;
                position = new Vector2(position.x + triangleBaseLength, position.y); 
            }
        }
    }


    public void checkGaps()
    {
        for (int i = 0; i < gaps.Length; i++)
        {
            if (gaps[i].isComplete())
            {
                //ebin;
            }
        }
    }
}
