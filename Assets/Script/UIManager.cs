using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform parent;

    [Header("Animation Settings")]
    public float animationDelayStep = 0.2f;

    void Start()
    {
        CreateItem("Body Scan", "Real-time skeletal mapping", "01", 0);
        CreateItem("Suit Deploy", "AR Iron Man overlay", "02", 1);
        CreateItem("Motion Sync", "Suit tracks every move", "03", 2);
        CreateItem("HUD Overlay", "Live data on-screen", "04", 3);
    }

    void CreateItem(string title, string subtitle, string value, int index)
    {
        GameObject obj = Instantiate(itemPrefab, parent);

        FeatureCardUI item = obj.GetComponent<FeatureCardUI>();
        item.SetData(title, subtitle, value);

        item.PlayAnimation(index * animationDelayStep);
    }
}