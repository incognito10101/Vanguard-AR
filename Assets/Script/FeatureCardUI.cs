using TMPro;
using UnityEngine;
using System.Collections;

public class FeatureCardUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI subtitleText;
    public TextMeshProUGUI valueText;

    [Header("Animation Settings")]
    public float duration = 0.3f;

    void Awake()
    {
        // Start hidden (no flash)
        transform.localScale = new Vector3(0, 1, 1);
        gameObject.SetActive(false);
    }

    public void SetData(string title, string subtitle, string value)
    {
        titleText.text = title;
        subtitleText.text = subtitle;
        valueText.text = value;
    }

    public void PlayAnimation(float delay)
    {
        gameObject.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(Animate(delay));
    }

    IEnumerator Animate(float delay)
    {
        yield return new WaitForSeconds(delay);
        float time = 0;
        while (time < duration)
        {
            float t = time / duration;
            t = Mathf.SmoothStep(0, 1, t);
            transform.localScale = new Vector3(Mathf.Lerp(0, 1, t), 1, 1);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = new Vector3(1, 1, 1);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}