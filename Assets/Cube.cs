using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cube : MonoBehaviour
{

    [SerializeField]
    Vector3 newScale = new Vector3 (2,2,2);
    Vector3 defaultScale;
 

    void OnAwake()
    {
        defaultScale = transform.localScale;
        
    }

    void OnMouseOver()
    {

        transform.localScale = newScale;

    }





}
