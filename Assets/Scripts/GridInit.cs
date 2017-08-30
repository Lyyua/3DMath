using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridInit : MonoBehaviour
{
    public GameObject zAxes;
    public GameObject xAxes;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        GameObject zPivot = new GameObject();
        zPivot.transform.localPosition = Vector3.zero;
        for (int i = 0; i < 10; i++)
        {
            GameObject go = Instantiate(zAxes);
            go.transform.localEulerAngles = Vector3.zero;
            go.transform.localPosition = new Vector3(i - 5, 0, 0);
            go.transform.SetParent(zPivot.transform);
        }

        GameObject xPivot = new GameObject();
        xPivot.transform.localPosition = Vector3.zero;
        for (int i = 0; i < 10; i++)
        {
            GameObject go = Instantiate(xAxes);
            go.transform.localEulerAngles = Vector3.zero;
            go.transform.localPosition = new Vector3(0, 0, i - 5);
            go.transform.SetParent(zPivot.transform);
        }
    }
}
