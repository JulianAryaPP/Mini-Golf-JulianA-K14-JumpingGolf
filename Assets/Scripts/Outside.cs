using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Outside : MonoBehaviour
{
    public UnityEvent onBallEnter = new UnityEvent();
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Ball"))
        {
            Debug.Log("BallOutside");
            onBallEnter.Invoke();
        }
    }
}
