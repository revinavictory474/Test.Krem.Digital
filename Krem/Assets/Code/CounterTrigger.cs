using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterTrigger : MonoBehaviour
{
    public int _countBlock;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Block"))
        {
            _countBlock++;
        }
    }
}
