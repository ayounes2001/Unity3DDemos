using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class TeleportEditor : MonoBehaviour
{
    public bool isTeleporting = true;
    public Transform teleportTarget;
    public GameObject player;
    public float Range = -10.0f;


 
    



    public void Teleporting()
    {
        Debug.Log("Teleporting Activated");
        //player.transform.position = teleportTarget.transform.position;
        
        player.transform.position = new Vector3(Random.Range(-Range, Range), 1, Random.Range(-Range, Range));
        player.SetActive(false);
        Invoke("DelayTeleport",1);
     
     

    }

    public void DelayTeleport()
    {
        player.SetActive(true);
    }
}
