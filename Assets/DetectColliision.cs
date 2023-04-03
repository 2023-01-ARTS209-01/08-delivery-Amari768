using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColliision : MonoBehaviour
{

 private bool hasPackage = false;
  SpriteRenderer spriteRenderer;
[SerializeField]  Color hasPackageColor;
[SerializeField]  Color doesNotHavePackageColor;

private void Start()
{
spriteRenderer = GetComponent<SpriteRenderer>();

}

private void OnCollisionEnter2D(Collision2D collision)
{

//Debug.Log("we hit something!!-"+ collision.gameObject.name);


}

private void OnTriggerEnter2D(Collider2D trigger)
{
if(trigger.gameObject.CompareTag("Package") && !hasPackage)
{
hasPackage = true;
spriteRenderer.color = hasPackageColor;
  Debug.Log("I have picked up package"); 
  Destroy(trigger.gameObject,0.5f); 
}
if(trigger.gameObject.CompareTag("Customer") && hasPackage)
{
   hasPackage = false; 
   spriteRenderer.color = doesNotHavePackageColor;
 Debug.Log("I have delivered to customer");     
Destroy(trigger.gameObject,0.5f);
}
    //Debug.Log("we went to trigger"+ trigger.gameObject.name);
}
}
