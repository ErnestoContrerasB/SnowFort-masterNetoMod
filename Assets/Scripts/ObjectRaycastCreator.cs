using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectRaycastCreator : MonoBehaviour
{

    private RaycastHit hit;
    private Ray ray = new Ray();
    private FillAmountObject objectToFill;
    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray();
    }

    // Update is called once per frame
    void Update()
    {
        
       //IncreaseAmount(increase);
    }

    private void FixedUpdate()
    {
        ray.origin = this.transform.position;
        ray.direction = this.transform.forward;

        Debug.DrawRay(this.transform.position, this.transform.forward * 5, Color.blue);
       
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Esta tocando algo");
            objectToFill = hit.collider.GetComponent<FillAmountObject>();
            if (objectToFill != null) {
                objectToFill.IncreaseAmount(true);
            }
        }
        else
        {
            

            if(objectToFill != null)
            {

               objectToFill.IncreaseAmount(false);
            }
            //hit.collider.GetComponent<FillAmountObject>().IncreaseAmount(true);
            Debug.Log("No hay nada chocando");
        }
    }



}
