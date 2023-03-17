using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColliision : MonoBehaviour
{
   

private void OnCollisionEnter2D(Collision2D collision)
{

Debug.Log("we hit something!!-"+ collision.gameObject.name);


}

private void OnTriggerEnter2D(Collider2D trigger)
{

    Debug.Log("we went to trigger"+ trigger.gameObject.name);
}
}
