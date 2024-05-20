using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scViewControl : MonoBehaviour {

    //Knives
    public GameObject[] KNIFE;
    public GameObject PIVOT;
    Vector3 histPosition;

    public int MAX_COUNT;
    int SEL_KNIFE;
    int HIST_KNIFE;
    bool isKeyDown;

	// Use this for initialization
	void Start () {
        //MAX_COUNT = KNIFE.Length;
        isKeyDown = false;

        SEL_KNIFE = -1;
        HIST_KNIFE = -1;
        SelectKnife(true);
    }
	
	// Update is called once per frame
	void Update () {
		if(!isKeyDown && Input.GetKeyDown(KeyCode.PageUp))
        {
            //isKeyDown = true;            
            SelectKnife(true);
        }
        else if (!isKeyDown && Input.GetKeyDown(KeyCode.PageDown))
        {
            //isKeyDown = true;
            SelectKnife(false);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            PIVOT.transform.Rotate(new Vector3(-5, 0, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            PIVOT.transform.Rotate(new Vector3(5, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            PIVOT.transform.Rotate(new Vector3(0, 0, 5));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            PIVOT.transform.Rotate(new Vector3(0, 0, -5));
        }

        if (Input.GetKeyUp(KeyCode.PageUp) || Input.GetKeyUp(KeyCode.PageDown))
        {
            isKeyDown = false;
        }
    }

    void SelectKnife(bool isUp)
    {

        PIVOT.transform.rotation = new Quaternion(0, 0, 0, 0);
        if (isUp)
        {
            SEL_KNIFE++;
            if (SEL_KNIFE > 12)
                SEL_KNIFE = 0;

        }
        else
        {
            SEL_KNIFE--;
            if (SEL_KNIFE < 0)
                SEL_KNIFE = 12;            

        }


        if (HIST_KNIFE > -1)
        {
            KNIFE[HIST_KNIFE].transform.parent = null;
            KNIFE[HIST_KNIFE].transform.position = histPosition;
            KNIFE[HIST_KNIFE].transform.rotation = new Quaternion(0, 0, 0, 0);
        }

        histPosition = KNIFE[SEL_KNIFE].transform.position;
        KNIFE[SEL_KNIFE].transform.SetParent(PIVOT.transform);
        KNIFE[SEL_KNIFE].transform.localPosition = Vector3.zero;
        PIVOT.transform.Rotate(new Vector3(-30, 0, 0));
        HIST_KNIFE = SEL_KNIFE;
    } 
}
