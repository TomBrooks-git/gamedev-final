using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sabot : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Vehicle"){
            //ApplyDamage(other.gameObject);
            Debug.Log("Hit");
            Destroy(this.gameObject);
        }
    }

    void ApplyDamage(GameObject target){
        
    }
}
