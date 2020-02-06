using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorButtonDemo : MonoBehaviour
{
    public bool isAttacking = true;
    public bool isTeleporting = true;
    public bool isWalking = true;
    public bool isDefending = true;

    public void Attacking()
    {
        Debug.Log("Monster is Attacking");
    }
    public void Teleporting()
    {
        Debug.Log("Monster is Teleporting");
    }
    public void Walking()
    {
        Debug.Log("Monster is Walking");
    }
    public void Defending()
    {
        Debug.Log("Monster is Defending");
    }
}
