using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLifetime : MonoBehaviour
{
    [SerializeField] private float _minLifetimeValue;
    [SerializeField] private float _maxLifetimeValue;
    private float _currentLifetimeValue;

    private void OnEnable()
    {
        _currentLifetimeValue = Random.Range(_minLifetimeValue, _maxLifetimeValue);
        StartCoroutine(DestroyCoin(gameObject, _currentLifetimeValue));
    }

    private IEnumerator DestroyCoin(GameObject coin, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(coin);
    }


   
}
