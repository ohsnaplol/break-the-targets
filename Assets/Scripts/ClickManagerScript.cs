using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManagerScript : MonoBehaviour
{
    void Update()
    {
        ClickToDestroy();
    }



    public void ClickToDestroy()
    {

        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position at the time of the click input
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Spawn a raycast that shoots out from the mouse position
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            // If the Raycast hits an object with a Collider2D
            if (hit.collider != null)
            {
                // Check if the hit object is the circle we want to destroy
                if (hit.collider.gameObject.CompareTag("Circle"))
                {
                    // Destroy the circle
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    }



}



