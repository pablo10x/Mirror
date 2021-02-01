using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
    private float move_vertical, move_horizontal;
    [ShowInInspector] private float movementspeed = 1f;
    private CharacterController charr;

    private void Start()
    {
        charr = GetComponent<CharacterController>();
        
    }


    [ClientCallback]
    private void Update()
    {
        if (!hasAuthority) return;
        
       /* move_horizontal = Input.GetAxis("Horizontal");
        move_vertical = Input.GetAxis("Vertical");
        
        Vector3 Movement = new Vector3(move_horizontal,0,move_vertical);
        charr.Move(Movement * movementspeed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(Movement);*/
    }
}
