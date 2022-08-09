using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenuIfClicked : MonoBehaviour
{
    public string ObjectName;
    public GameObject menuToOpen;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == ObjectName)
                { print("open:" + menuToOpen.gameObject.name); }
            }
        }
    }
}
