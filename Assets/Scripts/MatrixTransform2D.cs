using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixTransform2D : MonoBehaviour
{
    public Vector3 p;
    public Vector3 q;
    public GameObject line;
    public GameObject head;
    void Start()
    {
        Vector3 pDir = (p - Vector3.right).normalized;
        float pDistance = Vector3.Distance(p, Vector3.right);

        Vector3 qDir = (q - Vector3.forward).normalized;
        float qDistance = Vector3.Distance(q, Vector3.forward);
        for (int i = 1; i < 10; i++)
        {
            Vector3 piPoint = (pDir * pDistance * i / 10) + Vector3.right;
            DrawArrow(Vector3.zero, piPoint);
            Vector3 qiPoint = (qDir * qDistance * i / 10) + Vector3.forward;
            DrawArrow(Vector3.zero, qiPoint);
        }
        DrawArrow(Vector3.zero, p);
        DrawArrow(Vector3.zero, q);
    }

    void DrawArrow(Vector3 _start, Vector3 _end)
    {
        GameObject go = Instantiate(this.line);
        LineRenderer line = go.GetComponent<LineRenderer>();
        line.SetPosition(0, _start);
        line.SetPosition(1, _end);
        line.positionCount = 2;
        {
            GameObject arrow = Instantiate(head);
            Vector3 dir = (_end - _start).normalized;
            arrow.transform.rotation = Quaternion.LookRotation(dir);
            arrow.transform.position = _end;
        }
    }
}
