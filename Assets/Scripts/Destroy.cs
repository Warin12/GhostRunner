using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float life;

    public void Start()
    {
        Destroy(gameObject, life);
    }
}
