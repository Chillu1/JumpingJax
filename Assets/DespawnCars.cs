using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnCars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider myCollider = GetComponent<Collider>();
        myCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        CarMovement movement = other.gameObject.GetComponent<CarMovement>();
        if (movement != null)
        //if (other.gameObject.layer == 19)//vehicle layer
        {
            Debug.Log("Delete Car now");
            movement.ReturnToSpawner();
        }
    }
}
