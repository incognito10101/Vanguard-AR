using UnityEngine;

public class MovingBar : MonoBehaviour
{
    public RectTransform bar;
    public RectTransform parent;

    public float speed = 300f;

    float startX;
    float endX;

    void Start()
    {
        float parentWidth = parent.rect.width;
        float barWidth = bar.rect.width;

        startX = -parentWidth;

        endX = parentWidth;

        bar.anchoredPosition = new Vector2(startX, bar.anchoredPosition.y);
    }

    void Update()
    {
        bar.anchoredPosition += new Vector2(speed * Time.deltaTime, 0);

        if (bar.anchoredPosition.x > endX)
        {
            bar.anchoredPosition = new Vector2(startX, bar.anchoredPosition.y);
        }
    }
}