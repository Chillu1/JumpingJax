using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public Vector3 movement;

    private Vector3 initialPos;

    private void Start()
    {
        initialPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += movement * Time.deltaTime;
    }

    public void ReturnToSpawner()
    {
        transform.localPosition = initialPos;
        gameObject.SetActive(false);
    }
}
