using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ArrangeOrderActions : MonoBehaviour {
    private RectTransform panelRectTransform;
    void Start() {
        panelRectTransform = GetComponent<RectTransform>();
    }
    public void MoveDownOne()
    {
        int currentSiblingIndex = panelRectTransform.GetSiblingIndex(); panelRectTransform.SetSiblingIndex(currentSiblingIndex - 1);
    }

    public void MoveUpOne()
    {
        int currentSiblingIndex = panelRectTransform.GetSiblingIndex(); panelRectTransform.SetSiblingIndex(currentSiblingIndex + 1);
    }
}
