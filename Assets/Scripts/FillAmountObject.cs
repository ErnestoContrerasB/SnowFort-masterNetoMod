using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillAmountObject : MonoBehaviour
{
    public Image targetImage;
    public bool increase;
    public InstanceManager obj;
    public void IncreaseAmount(bool isIncreasing)
    {
        if (isIncreasing)
        {
            targetImage.fillAmount = targetImage.fillAmount + Time.deltaTime;
        }
        else
        {
            targetImage.fillAmount = targetImage.fillAmount - Time.deltaTime;
        }
        if (targetImage.fillAmount >= 1)
        {
            targetImage.fillAmount = 0;
            obj.CreateObject();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        IncreaseAmount(increase);
    }
}
