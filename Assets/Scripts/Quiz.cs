using UnityEngine;

public class Quiz : MonoBehaviour
{

    // Write a code that adds a menu item to the component called "Reset Object" that removes the Rigidbody off the object and places it back to 0, 0, 0.


    [ContextMenu("Reset Object")]

    void AddComponentItem()
    {

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            Destroy(rb);
        }
        transform.position = new Vector3(0, 0, 0);
    }



}
