using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOutUI : MonoBehaviour
{
    public Image fadeImage;
    public float duration = 2f;

    void Start()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float time = 0f;
        Color color = fadeImage.color;

        while (time < duration)
        {
            time += Time.deltaTime;
            float alpha = Mathf.Lerp(1, 0, time / duration);
            fadeImage.color = new Color(color.r, color.g, color.b, alpha);
            yield return null;
        }

        fadeImage.color = new Color(color.r, color.g, color.b, 0);

        fadeImage.gameObject.SetActive(false);
    }
}