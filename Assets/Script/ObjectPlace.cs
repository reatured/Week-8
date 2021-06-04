using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlace : MonoBehaviour
{
    public Transform objectToPlace;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            objectToPlace.position = hit.point;

            objectToPlace.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);

        }
    }
}
