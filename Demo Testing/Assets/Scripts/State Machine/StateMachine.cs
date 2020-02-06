using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
   
    public enum States
    {
        Attacking,
        Teleporting,
        Defending,
        Walking
    }

    public States currentState;


    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case States.Attacking:
                Debug.Log("Monster is Attacking!");
                break;
            case States.Defending:
                Debug.Log("Monster is Defending!");
                break;
            case States.Teleporting:
                Debug.Log("Monster is Teleporting!");
                break;
            default:
            case States.Walking:
                Debug.Log("Monster is Moving!");
                break;
        }
    }

}

