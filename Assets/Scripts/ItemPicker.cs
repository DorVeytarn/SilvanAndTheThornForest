using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] private UnityEvent _coinMatched;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Coin coin))
        {
            _coinMatched?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
