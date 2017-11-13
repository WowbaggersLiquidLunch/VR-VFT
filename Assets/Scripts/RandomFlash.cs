using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class RandomFlash : MonoBehaviour {
	Vector3 lightPosition;
    int i;
    List<ViewPoint> viewPoints;
    //const double z; hold the constant of the z distance

    //SteamVR_ControllerManager conts;
	// Use this for initialization
	void Start () {
		lightPosition = new Vector3 (0, 0, 0);
        i = 0;
        viewPoints = new List<ViewPoint>(50);
        float radius = 50;
        int col = 4;
        float x = (float) -1.5;
        float y = (float) 4.5;
        float cellDist = radius / 12;
        int counter = 0;
        bool top = true;
        /*
        while(true) {
            if (col != 10 && top)
            {
                if (col % (++counter) != 0)
                {
                    viewPoints.Insert(i++, new ViewPoint(x * cellDist, y * cellDist));
                    x++;
                }
                else
                {
                    viewPoints.Insert(i++, new ViewPoint(x * cellDist, y * cellDist));
                    x -= col;
                    y -= 1;
                    col += 2;
                }
            } else if (!top)
            {
                if (col % (++counter) != 0)
                {
                    viewPoints.Insert(i++, new ViewPoint(x * cellDist, y * cellDist));
                    x++;
                }
                else
                {
                    viewPoints.Insert(i++, new ViewPoint(x * cellDist, y * cellDist));
                    x -= col;
                    y -= 1;
                    col -= 2;
                    if(col == 2) { break; }
                }
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    x = (float) -5.5;
                    for (int k = 0; k < 10; k++)
                    {
                        viewPoints.Insert(i++, new ViewPoint(x * cellDist, y * cellDist));
                        x++;
                    }
                    y -= 1;
                }
                top = false;
            }
        }
        foreach(ViewPoint vp in viewPoints)
        {
            Debug.Log(vp.ToString());
        }
        */
		InvokeRepeating ("ChangePosition", 0, 2);

    }

    private void HandleClick(object sender, ClickedEventArgs e)
    {
        Debug.Log("Trigger Pressed");
        ChangePosition();
        return;
    }
	
	// Update is called once per frame
	void Update () {

    }



	void ChangePosition () {
        //viewPoints.Insert(i, new ViewPoint(x, y));
		lightPosition = new Vector3 (UnityEngine.Random.Range (-5, 5), (float)0.001, UnityEngine.Random.Range (-5,5));
        transform.localPosition = lightPosition;
    }
}
