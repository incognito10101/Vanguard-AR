using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float distanceFromCamera = 2.0f;
    public Vector2 screenPadding = new Vector2(0, 0); 

    void LateUpdate()
    {
        if (Camera.main == null) return;
        Camera cam = Camera.main;
        float targetX = 1.0f - screenPadding.x;
        float targetY = 0.0f + screenPadding.y;
        Vector3 targetViewportPos = new Vector3(targetX, targetY, distanceFromCamera);
        Vector3 worldPos = cam.ViewportToWorldPoint(targetViewportPos);
        transform.position = worldPos;
        //transform.LookAt(cam.transform);
        transform.Rotate(0f, 100f * Time.deltaTime, 0f);
    }
}
