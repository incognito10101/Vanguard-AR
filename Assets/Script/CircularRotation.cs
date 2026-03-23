using UnityEngine;

public class CircularRotation : MonoBehaviour
{
    public float rotationSpeed = 50f;
    
    void Update()
    {
        transform.Rotate(0, 0, -(rotationSpeed * Time.deltaTime));
    }
}
