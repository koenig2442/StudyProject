using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 a = new Vector3(1, 2, 3);

        a.x = 10;
        a.y = 20;
        a.z = 30;

        Vector3 b = new Vector3(3, 6, 9);
        b = b * 10;

        Vector3 ab = new Vector3(2, 4, 8);
        Vector3 ac = new Vector3(3, 6, 9);

        Vector3 bc = ab  +  ac;

        Vector3 c = new Vector3(2, 4, 8);
        Vector3 d = new Vector3(3, 6, 9);

        Vector3 e = c - d;

        Vector3 f = new Vector3 (3,3,3);
        Vector3 g = f.normalized;

        Vector3 h = new Vector3(3, 3, 3);
        float i = h.magnitude;

        Vector3 j = new Vector3 (0,1,0);
        Vector3 k = new Vector3 (1,0,0);
        float l = Vector3.Dot(j, k);

        Vector3 m = new Vector3 (0,0,1);
        Vector3 n = new Vector3 (1,0,0);
        Vector3 o = Vector3.Cross (m, n);

        Vector3 currentPos = new Vector3(1,0,1);
        Vector3 destPos = new Vector3 (5,3,5);

        Vector3 delta = destPos - currentPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
