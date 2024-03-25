using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Color[] colors;
    public GameObject itemPrefab;

    public Transform contentParent;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Color color in colors)
        {
            var item = Instantiate(itemPrefab, contentParent);
            item.GetComponent<Image>().color = color;
        }
    }
}
