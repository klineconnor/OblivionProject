using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

    Camera cam;
    public float distance;
    interactible interactible;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Interact();
    }

    void Interact()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
			if (Input.GetButtonDown("Interact"))
            {
                interactible = hit.transform.GetComponent<interactible>();
                if(interactible != null)
                {
                    interactible.Interact();
                }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * distance;
        Gizmos.DrawRay(transform.position, direction);
    }
}
