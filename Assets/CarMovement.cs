using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider myCollider = GetComponent<BoxCollider>();
        //myCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += movement * Time.deltaTime;
    }
}
