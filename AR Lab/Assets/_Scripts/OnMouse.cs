using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour
{
   
    int c = 0;
    int x = 0;
    private bool firstTime = true;

    private void Start()
    {
        //StartCoroutine(WaterEffect());
    }
    // Start is called before the first frame update
    void OnMouseDown()
    {
        ChangeState();
    }

    void ChangeState()
    {
        if (x == 0)
        {
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);
            x++;
        }
        else

            if (x == 1)
        {
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(false);

            x++;
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);
            x = 0;

        }
    }

}
