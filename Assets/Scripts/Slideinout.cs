using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slideinout : MonoBehaviour
{
    private bool ausloeser;
    public float mypos;
    private float offset_x = 3000;
    private float beschleuniger;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    
    void Update()
    {
        mypos = transform.localPosition.x;
        if (ausloeser)
        {
            PushInUpdate();
        }
        else
        {
            PushOutUpdate();
        }
    }


    private void PushInUpdate()
    {

        if (transform.localPosition.x > 0)
        {
            beschleuniger += 0.25f;
            offset_x -= beschleuniger;
            transform.localPosition = new Vector3(offset_x, 0, 0);
        }



    }

    private void PushOutUpdate()
    {
        if (transform.localPosition.x < 4000)
        {
            beschleuniger += 0.25f;
            offset_x += beschleuniger;
            transform.localPosition = new Vector3(offset_x, 0, 0);

        }
        
    }

    public void PushIn()
    {     
        beschleuniger = 0f;
        ausloeser = true;
    }


    public void PushOut()
    {     
        beschleuniger = 0f;
        ausloeser = false;
    }



}
