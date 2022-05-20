using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{   
    [SerializeField]
    float gravity = 9.8f;
    Transform body;

    public void Attract(Transform body)
    {
        this.body = body;
        Vector3 attractDir = (transform.position - body.position).normalized;
        Vector3 bodyUp = body.up;

        Quaternion targetAngle = Quaternion.FromToRotation(bodyUp,attractDir)*body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation,targetAngle,50*Time.deltaTime);


        body.GetComponent<Rigidbody>().AddForce(attractDir * gravity*Time.deltaTime);
        
        

    }


}
