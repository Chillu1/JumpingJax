using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnCars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider myCollider = GetComponent<BoxCollider>();
        myCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.GetComponent<CarMovement>())
        if (other.gameObject.layer == 19)//vehicle layer
        {
            Debug.Log("Delete Car now");
            GameObject.Destroy(other.gameObject);
        }
    }
}
