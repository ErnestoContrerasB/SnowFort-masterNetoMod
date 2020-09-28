using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray();

        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(ray.origin, hit.point);
            Debug.Log("El rayo anda chocando " + hit.transform.name);
            hit.collider.GetComponent<FillAmountObject>().IncreaseAmount(true);
        }
    }
}
