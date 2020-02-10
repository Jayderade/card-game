using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapCard : MonoBehaviour
{
    public bool swap;
    public Image c;
    // Start is called before the first frame update
    void Start()
    {       
        swap = HandSpace.overPlay;
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0) && swap)
        {
            c.enabled = false;
        }
    }
}
