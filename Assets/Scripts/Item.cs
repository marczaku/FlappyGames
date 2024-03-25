using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public Canvas canvasPrefab;
    private Canvas _canvasInstance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _canvasInstance = Instantiate(canvasPrefab);
        this.transform.SetParent(_canvasInstance.transform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag.");
        transform.position = eventData.position;
    }
}
