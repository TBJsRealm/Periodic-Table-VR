using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSelector : MonoBehaviour
{

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
                    PrintName(hit.transform.gameObject);
                   hit.transform.GetComponent<Transform>().Translate (-9.92f, 5f, -0.525f);

                }
            }
        }
        
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

}
