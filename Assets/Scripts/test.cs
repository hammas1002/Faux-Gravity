using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform player;
    Quaternion targetAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 direction = (player.position - transform.position).normalized;

            Vector3 playerUp = player.up;

            print("player up: "+playerUp);

            targetAngle = Quaternion.FromToRotation(player.up,direction)*player.rotation;

            print(targetAngle);
        }
        if (Input.GetMouseButtonDown(1))
        {
            player.rotation = targetAngle;
        }
    }

    private void OnDrawGizmos()
    {
        Vector3 direction = (transform.position-player.position).normalized;

        Vector3 playerUp = player.up;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(player.position,player.up*5+player.position);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(player.position, direction*3 + player.position);
    }
}
