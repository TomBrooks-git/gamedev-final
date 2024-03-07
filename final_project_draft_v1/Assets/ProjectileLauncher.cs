using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField] public GameObject sabotPrefab;
    [SerializeField] float speed = 50f;
    bool canFire;
    [SerializeField] float timer = 8;
    [SerializeField] float countUp = 0;

    void Start(){
        canFire = true;
    }

    void Update(){
        if(canFire == false){
            countUp += Time.deltaTime;
            if(countUp >= timer){
                canFire = true;
                countUp = 0;
            }
        }

    }

    
    public void Launch(){
        if(canFire){    
            GameObject newProjectile = Instantiate(sabotPrefab, transform.position, Quaternion.identity);
            Destroy(newProjectile, 10f);
            newProjectile.transform.rotation = sabotPrefab.transform.rotation = transform.rotation;
            newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.transform.up * speed;
            canFire = false;
        }
    }
}
