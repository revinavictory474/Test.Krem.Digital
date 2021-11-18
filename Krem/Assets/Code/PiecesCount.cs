using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesCount : MonoBehaviour
{
    private Rigidbody rb;

    public PiecesCount(Rigidbody rigidbody)
    {
        rb = rigidbody;
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }
}
