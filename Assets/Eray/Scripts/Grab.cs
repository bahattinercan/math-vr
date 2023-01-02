using UnityEngine;

public class Grab : MonoBehaviour
{
    public bool canGrab = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("I can grab");
            canGrab = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("I can not grab");
            canGrab = false;
        }
    }
}