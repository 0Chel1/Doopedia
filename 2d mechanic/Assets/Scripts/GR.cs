using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = UnityEngine.Random;

public class GR : MonoBehaviour
{
    public Vector2Int size;
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6;
    public float sid, n, zoom = 20f;

    void Start()
    {
        sid = Random.Range(0, 9999999);
        for (int i = 0; i < size.y; i++)
        {
            for (int j = 0; j < size.x; j++)
            {
                n = Mathf.PerlinNoise((i + sid) / zoom, (j + sid) / zoom);
                if (n < 0.4)
                {
                    Quaternion rot = Quaternion.Euler(0, 0, 0);
                    Instantiate(obj1, new Vector2(i, j), rot);
                }
                else if (n > 0.4 && n < 0.5)
                {
                    Quaternion rot = Quaternion.Euler(0, 0, 0);
                    Instantiate(obj2, new Vector2(i, j), rot);
                }
                else if (n > 0.5 && n < 0.55)
                {
                    Quaternion rot = Quaternion.Euler(0, 0, 0);
                    Instantiate(obj3, new Vector2(i, j), rot);
                }
                else if (n > 0.55 && n < 0.8)
                {
                    Quaternion rot = Quaternion.Euler(0, 0, 0);
                    Instantiate(obj4, new Vector2(i, j), rot);
                }
                else if (n > 0.8 && n < 0.9)
                {
                    Quaternion rot = Quaternion.Euler(0, 0, 0);
                    Instantiate(obj5, new Vector2(i, j), rot);
                }
                else if (n > 0.9)
                {
                    Quaternion rot = Quaternion.Euler(0, 0, 0);
                    Instantiate(obj6, new Vector2(i, j), rot);
                }
            }
        }
    }
}
