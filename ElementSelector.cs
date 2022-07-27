using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSelector : MonoBehaviour
{
    int count = 0;
    Vector3 prevPos;
    Vector3 goal = new Vector3(0, 15, 0);

    //public GameObject Atom;


    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    if(hit.transform.gameObject.name == "Front Panel" && count == 0)
                    {
                        prevPos = hit.transform.position;
                        hit.transform.GetComponent<Transform>().Translate(goal-prevPos);
                        //hit.transform.GetComponent<Transform>().transform.position = Vector3.MoveTowards(transform.position, goal, Time.deltaTime * 1000);
                        hit.transform.gameObject.transform.localScale = new Vector3(5, 70, 0.05f);
                        count = 1;
                    }
                    else
                    {
                        if (hit.transform.gameObject.transform.position == goal && count == 1)
                        {
                            hit.transform.GetComponent<Transform>().Translate(prevPos - goal);
                            hit.transform.gameObject.transform.localScale = new Vector3(1, 14, 0.05f);
                            count = 0;
                        }
                    }
                }
            }
        }
        
    }
    /*
    public void MoveAtom()
    {
        Atom.transform.Translate(0, 0, 0);
    }
    */
}
