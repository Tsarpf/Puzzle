using Assets.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Pyramid
{

    Triangle[] triangles;
    UnityEngine.Object trianglePrefab;

    Gap[] gaps;

    public Pyramid(int floorCount)
    {
    //        trianglePrefab = Resources.Load("gradienttriangle.prefab");
        trianglePrefab = GameObject.Find("gradienttriangle");   //how to do this properly?

        constructPyramid(floorCount);
    }

    private void constructPyramid(int floorCount)
    {
        triangles = new Triangle[floorCount*(floorCount+1) / 2];
        float triangleBaseLength = 0.8F;        //need to set this relative to sprite scale
        float triangleHeight = triangleBaseLength * 3 / 4;
        float center = 1;
        Vector2 position = new Vector2(center, center);
        //building from top down
        int idx = 0;

        for(int y = 1; y <= floorCount; y++)        //create triangles
        {
            position = new Vector2(center - triangleBaseLength/2 - (triangleBaseLength/2 * (y-1)), position.y - triangleHeight);

            for (int x = 0; x < y; x++)
            {
                triangles[idx] = new Triangle(position, trianglePrefab);
                
                idx ++;
                position = new Vector2(position.x + triangleBaseLength, position.y); 
            }
        }
        int gapIdx = 0;
        idx = 0;

        gaps = new Gap[floorCount * (floorCount - 1) / 2];

        for (int y = 1; y <= floorCount; y++)   //create gaps
        {
            for (int x = 0; x < y; x++)
            {
                if (x + 1 < y)      //if not at the last triangle in the row
                {
                    gaps[gapIdx] = new Gap(triangles[idx], triangles[idx + 1], triangles[idx - (y - 1)]);
                    gapIdx++;
                }
                idx++;
            }
        }
    }


    public void checkGaps()
    {
        for (int i = 0; i < gaps.Length; i++)
        {
            if (gaps[i].isComplete())
            {
                //create bigger triangle out of finished triangles?
            }
        }
    }
}
