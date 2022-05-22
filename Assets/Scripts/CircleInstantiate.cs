using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstantiate : MonoBehaviour
{
    public GameObject Template;


    private void Start()
    {
         GameObject newObject =  Instantiate(Template, Vector3.zero, Quaternion.identity);

    }


}
