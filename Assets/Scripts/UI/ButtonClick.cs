using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] Color _targetColor;
    private Text _text;

    private void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    public void OnButtonClick()
    {
        gameObject.transform.localScale = new Vector2(0.9f, 0.9f);
        Invoke("Return", 0.2f);
    }

    private void Return()
    {
        gameObject.transform.localScale = new Vector2(1f, 1f);
    }
}
