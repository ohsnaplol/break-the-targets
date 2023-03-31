using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManagerScript : MonoBehaviour
{

    public GameObject clickedTarget = null;

    void Update()
    {
        CheckForTargetCollision();

        if(CollisionOcurred())
        {
            DestroyTarget(clickedTarget);
        }
    }

    public bool CollisionOcurred()
    {
        return (clickedTarget != null);
    }

    public void CheckForTargetCollision()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position at the time of the click input
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Spawn a raycast that shoots out from the mouse position
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            // If the Raycast hits an object with a Collider2D
            if(hit.collider.gameObject.CompareTag("Circle"))
            {
                // Set the target to be destroyed
                clickedTarget = hit.collider.gameObject;
            }
        }
    }


    public void DestroyTarget(GameObject target)
    {
        Destroy(target);
    }

}



