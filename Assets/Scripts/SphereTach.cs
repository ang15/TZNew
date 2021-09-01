using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereTach : MonoBehaviour
{
    [SerializeField]
    public Text los;
    [SerializeField]
    private SphereBull sphereBull;


    void Start()
    {
        
    }


    private void OnMouseDrag()
    {
        if (UiPanel.TrueOrFalse == false)
        {
            UiPanel.Increase = true;
        }
    }
    private void OnMouseUp()
    {
        UiPanel.Increase = false;
    }


    void Update()
    {
        if (UiPanel.Increase == true)
        {
            if (UiPanel.TrueOrFalse == false)
            {

                Instantiate(sphereBull, new Vector3(-122,1, 169), Quaternion.identity);
                UiPanel.TrueOrFalse = true;
                if (transform.localScale.x > 2)
                {
                    transform.localScale -= new Vector3(1, 1, 1);
                }
            }
            else if (UiPanel.TrueOrFalse == true)
            {
                Increases();
            }
        }
      
    }

  
    public void Increases()
    {
        if (transform.localScale.x > 2)
        {
            transform.localScale -= new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime); 
        }
        else
        {
            los.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
