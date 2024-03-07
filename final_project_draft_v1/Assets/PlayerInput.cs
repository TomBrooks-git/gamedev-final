using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] BradleyChassis chassis;
    [SerializeField] T90Chassis t90Chassis;

    public Transform bradleyTurretTransform;
    public Transform t90TurretTransform;

    bool vehicleSwitch = true;
    void Start(){
        
    }
    
    void Update(){
           if(Input.GetKey(KeyCode.G))
           {
                vehicleSwitch = !vehicleSwitch;
           }
           if(vehicleSwitch){
                T90();
           }
           else{
                Bradley();
           }
            
    }

    void T90(){
        Vector3 chassisRotate = Vector3.zero;
        Vector3 chassisMovement = Vector3.zero;
        

        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)){
            chassisRotate.z -= 1;
            if(!Input.GetKey(KeyCode.Space)){
                chassisMovement.y += 0.1f;
            }
            t90Chassis.RotateT90Chassis(chassisRotate);
            t90Chassis.MoveT90Chassis(chassisMovement);
            return;
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)){
            chassisRotate.z += 1;
            if(!Input.GetKey(KeyCode.Space)){
                chassisMovement.y += 0.1f;
            }
            t90Chassis.RotateT90Chassis(chassisRotate);
            t90Chassis.MoveT90Chassis(chassisMovement);
            return;
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)){
            chassisRotate.z -= 1;
            if(!Input.GetKey(KeyCode.Space)){
                chassisMovement.y -= 0.1f;
            }
            t90Chassis.RotateT90Chassis(chassisRotate);
            t90Chassis.MoveT90Chassis(chassisMovement);
            return;
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)){
            chassisRotate.z += 1;
            if(!Input.GetKey(KeyCode.Space)){
                chassisMovement.y -= 0.1f;
            }
            t90Chassis.RotateT90Chassis(chassisRotate);
            t90Chassis.MoveT90Chassis(chassisMovement);
            return;
        }

        if(Input.GetKey(KeyCode.W)){
            Debug.Log("W is pressed");
            chassisMovement.y += 1;
        }
        if(Input.GetKey(KeyCode.S)){

            chassisMovement.y -= 1;
        }
        if(Input.GetKey(KeyCode.A)){
            Debug.Log("A is pressed");
            chassisMovement.z += 1;
        }
        if(Input.GetKey(KeyCode.D)){
            Debug.Log("D is pressed");
            chassisMovement.z += -1;
        }
        
        t90Chassis.MoveT90Chassis(chassisMovement);
    }

    void Bradley(){
            Vector3 chassisRotate = Vector3.zero;
            Vector3 chassisMovement = Vector3.zero;
            

            if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)){
                chassisRotate.z -= 1;
                if(!Input.GetKey(KeyCode.Space)){
                    chassisMovement.y += 0.1f;
                }
                chassis.RotateBradleyChassis(chassisRotate);
                chassis.MoveBradleyChassis(chassisMovement);
                return;
            }
            if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)){
                chassisRotate.z += 1;
                if(!Input.GetKey(KeyCode.Space)){
                    chassisMovement.y += 0.1f;
                }
                chassis.RotateBradleyChassis(chassisRotate);
                chassis.MoveBradleyChassis(chassisMovement);
                return;
            }
            if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)){
                chassisRotate.z -= 1;
                if(!Input.GetKey(KeyCode.Space)){
                    chassisMovement.y -= 0.1f;
                }
                chassis.RotateBradleyChassis(chassisRotate);
                chassis.MoveBradleyChassis(chassisMovement);
                return;
            }
            if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)){
                chassisRotate.z += 1;
                if(!Input.GetKey(KeyCode.Space)){
                    chassisMovement.y -= 0.1f;
                }
                chassis.RotateBradleyChassis(chassisRotate);
                chassis.MoveBradleyChassis(chassisMovement);
                return;
            }

            if(Input.GetKey(KeyCode.W)){
                Debug.Log("W is pressed");
                chassisMovement.y += 1;
            }
            if(Input.GetKey(KeyCode.S)){

                chassisMovement.y -= 1;
            }
            if(Input.GetKey(KeyCode.A)){
                Debug.Log("A is pressed");
                chassisMovement.z += 1;
            }
            if(Input.GetKey(KeyCode.D)){
                Debug.Log("D is pressed");
                chassisMovement.z += -1;
            }
            
            chassis.MoveBradleyChassis(chassisMovement);

           
    }

    void rotateT90Turret(Transform transform)
    {
        Vector3 targetPos = Input.mousePosition;
        targetPos = Camera.main.ScreenToWorldPoint(new Vector3(targetPos.x, targetPos.y, Camera.main.transform.position.z));
        Vector3 direction = targetPos - t90TurretTransform.position;
        t90TurretTransform.rotation = Quaternion.LookRotation(transform.forward, targetPos - transform.position);
    }

    void rotateBradleyTurret(Transform transform)
    {
        Vector3 targetPos = Input.mousePosition;
        targetPos = Camera.main.ScreenToWorldPoint(new Vector3(targetPos.x, targetPos.y, Camera.main.transform.position.z));
        Vector3 direction = targetPos - bradleyTurretTransform.position;
        bradleyTurretTransform.rotation = Quaternion.LookRotation(transform.forward, targetPos - transform.position);
    }
}
