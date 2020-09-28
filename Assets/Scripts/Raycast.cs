using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private FillAmountObject objectToFill;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Ray ray = new Ray();
        ray.origin = this.transform.position;
        ray.direction = this.transform.forward;

        RaycastHit hit;

        // Debug.DrawLine(ray.origin, Vector3.zero);
        if (Physics.Raycast(ray, out hit))
        {
            //hit.collider.GetComponent<FillAmountObject>().IncreaseAmount(true);
            Debug.DrawLine(ray.origin, hit.point);
            Debug.Log("El rayo está chocando con algo " + hit.transform.name);
            objectToFill = hit.collider.GetComponent<FillAmountObject>();

            if (objectToFill != null)
            {
                objectToFill.IncreaseAmount(true);
            }
        }
    }
}
