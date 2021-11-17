using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayc : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                var rig = hit.collider.GetComponent<Rigidbody>();
                
                if(rig != null)
                {
                   // rig.isKinematic = false;
                    rig.AddForceAtPosition(ray.direction * 100.0f, hit.point, ForceMode.VelocityChange);
                }
            }
        }
    }
}
