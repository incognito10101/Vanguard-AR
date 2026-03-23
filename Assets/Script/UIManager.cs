using UnityEngine;
using static UnityEditor.Progress;

public class UIManager : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform parent;

    void Start()
    {
        CreateItem("Body Scan", "Real-time skeletal mappingx", "01");
        CreateItem("Suit Deploy", "AR Iron Man overlay", "02");
        CreateItem("Motion Sync", "Suit tracks every move", "03");
        CreateItem("HUD Overlay", "Live data on-screen", "04");
    }

    void CreateItem(string title, string subtitle, string value)
    {
        GameObject obj = Instantiate(itemPrefab, parent);

        FeatureCardUI item = obj.GetComponent<FeatureCardUI>();
        item.SetData(title, subtitle, value);
    }
}
