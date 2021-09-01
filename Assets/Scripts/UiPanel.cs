using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UiPanel : MonoBehaviour
{
    public static bool Increase;
    public static bool DoorOpen;
    public static bool TrueOrFalse;

 /*

    private void OnMouseDrag()
    {
        if (TrueOrFalse == false)
        {
            Increase = true;
        }
    }
    private void OnMouseUp()
    {
        Increase = false;
    }
 */
   
    void Start()
    {
        TrueOrFalse = true;
        DoorOpen = false;


    }


    void Update()
    {
        
    }
}
