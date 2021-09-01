using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{

    [SerializeField]
    private Text finish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UiPanel.DoorOpen == true)
        {
            Open();
        }
    }
    void Open()
    {
        if (transform.rotation.y> 0)
        {
            Quaternion quaternion = Quaternion.AngleAxis(1, new Vector3(0, -10, 0));
            transform.rotation *= quaternion;
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Sphere")
        {
            finish.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
