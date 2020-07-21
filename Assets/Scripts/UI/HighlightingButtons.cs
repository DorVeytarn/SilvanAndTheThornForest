using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HighlightingButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private HighlightedElement[] _highlightedElements;
    private Color _targetColorOpaque;
    private Color _targetColorTransparent;
    private Image _elementImage;

    private void Start()
    {
        _highlightedElements = gameObject.GetComponentsInChildren<HighlightedElement>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.localScale = new Vector2(1.1f, 1.1f);

        for (int i = 0; i < _highlightedElements.Length; i++)
        {
            _elementImage = _highlightedElements[i].GetComponent<Image>();
            _elementImage.color = new Color(_elementImage.color.r, _elementImage.color.g, _elementImage.color.b, 1f); ;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.transform.localScale = new Vector2(1f, 1f);

        for (int i = 0; i < _highlightedElements.Length; i++)
        {
            _elementImage = _highlightedElements[i].GetComponent<Image>();
            _elementImage.color = new Color(_elementImage.color.r, _elementImage.color.g, _elementImage.color.b, 0f); ;
        }
    }

}
