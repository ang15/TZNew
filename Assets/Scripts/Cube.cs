using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private float ySphere;
    private bool trueOrFalse;

    void Start()
    {
        ySphere = 0;
    }

    void Update()
    {
        if (UiPanel.Increase == true)
        {

            if (UiPanel.TrueOrFalse == false)
            {

                    transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
                 //   trueOrFalse = true;
                
            }
            Increase();

        }
    }

    public void Increase()
    {
        if (transform.localScale.x < 15)
        {
            ySphere += Time.deltaTime;
            transform.localScale += new Vector3(Time.deltaTime,0, 0);
        //    transform.position = new Vector3(transform.position.x, (0.9+ySphere), transform.position.y);
       //1-49
        }
    }
}
