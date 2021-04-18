using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class selectObjectTigid : MonoBehaviour
{
    public bool hide;
    public GameObject[] targets;
    public GameObject blackscreen;
    public int i;

    private void Start()
    {
        blackscreen.SetActive(!hide);
    }
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.name == "buttonOn")
                {
                    for (i = 0; i < targets.Length; i++)
                    {
                        targets[i].SetActive(!hide);
                        blackscreen.SetActive(hide);

                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.name == "buttonOff")
                {
                    for (i = 0; i < targets.Length; i++)
                    {
                        targets[i].SetActive(hide);
                        blackscreen.SetActive(!hide);

                    }
                }
            }
        }
    }
}
