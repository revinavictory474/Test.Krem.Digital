using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayc : MonoBehaviour
{
    public VisibleBlockController[] visibleController;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                for (int i = 0; i < visibleController.Length; i++)
                {
                    if (visibleController[i].transform.position == hit.transform.position)
                    {
                        visibleController[i].SendMessage("SetVisiblePiecesBlock");
                    }
                }

                var rig = hit.collider.GetComponent<Rigidbody>();
                if (rig != null)
                {
                    rig.AddForceAtPosition(ray.direction * 100.0f, hit.point, ForceMode.VelocityChange);
                }

            }
        }
    }
}
