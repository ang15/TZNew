using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereBull : MonoBehaviour
{
    private Rigidbody _rigidbody;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (UiPanel.Increase == true)
        {
            Increase();
        }else
        {
            if (UiPanel.DoorOpen == true)
            {
                Move1();
            }
            else
            {
                Move();
            }
        }

    
    }

   public void Increase() 
    {
        if (transform.localScale.x < 10)
        {
            transform.localScale += new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);
        }
        else{
            UiPanel.DoorOpen = false;
        }
    }

    public void Move()
    {
        _rigidbody.velocity = Vector3.right * Time.deltaTime * 500;
    }
    public void Move1()
    {
        _rigidbody.velocity = Vector3.right * Time.deltaTime * 100;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "cylinder")
        {

            StartCoroutine(Wait());
        }
        else if (other.tag == "stop")
        {
            UiPanel.DoorOpen = true;
        }

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);

        Destroy(gameObject);
        UiPanel.TrueOrFalse = false;

    }
}
