using UnityEngine;

public class SuitEntryAnimation : MonoBehaviour
{
    public float duration = 3f;

    public float startZ = 21f;
    public float endZ = 4f;

    public float startX = 0f;
    public float endX = -2f;

    public float startYRot = 180f;
    public float endYRot = 135f;

    public float startXRot = 0f;
    public float endXRot = -90f;

    // Hover settings
    public float hoverAmplitude = 0.1f; // kitna upar neeche
    public float hoverSpeed = 2f;

    private float time = 0f;
    private bool isAnimating = true;

    private float baseY;

    void Start()
    {
        transform.position = new Vector3(startX, transform.position.y, startZ);
        transform.rotation = Quaternion.Euler(startXRot, startYRot, 0f);

        baseY = transform.position.y;
    }

    void Update()
    {
        if (isAnimating)
        {
            time += Time.deltaTime;
            float t = time / duration;

            t = Mathf.Clamp01(t);

            // smoothstep
            t = t * t * (3f - 2f * t);

            // Position
            float newZ = Mathf.Lerp(startZ, endZ, t);
            float newX = Mathf.Lerp(startX, endX, t);

            // Rotation
            float newYRot = Mathf.Lerp(startYRot, endYRot, t);
            float newXRot = Mathf.Lerp(startXRot, endXRot, t);

            transform.position = new Vector3(newX, baseY, newZ);
            transform.rotation = Quaternion.Euler(newXRot, newYRot, 0f);

            if (t >= 1f)
            {
                isAnimating = false;

                // baseY update after final position
                baseY = transform.position.y;
            }
        }
        else
        {
            float hoverY = Mathf.Sin(Time.time * hoverSpeed) * hoverAmplitude;
            transform.position = new Vector3(
                transform.position.x,
                baseY + hoverY,
                transform.position.z
            );
        }
    }
}