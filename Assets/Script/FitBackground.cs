using UnityEngine;

public class FitBackground : MonoBehaviour
{
    public float distance = 5f;

    void Start()
    {
        Camera cam = Camera.main;

        float height = 2f * distance * Mathf.Tan(cam.fieldOfView * 0.5f * Mathf.Deg2Rad);
        float width = height * cam.aspect;

        transform.position = cam.transform.position + cam.transform.forward * distance;
        transform.localScale = new Vector3(width, height, 1);
    }
}