using TMPro;
using UnityEngine;

public class FeatureCardUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI subtitleText;
    public TextMeshProUGUI valueText;

    public void SetData(string title, string subtitle, string value)
    {
        titleText.text = title;
        subtitleText.text = subtitle;
        valueText.text = value;
    }
}
