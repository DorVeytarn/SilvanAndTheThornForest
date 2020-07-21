using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour
{
    [SerializeField] private GameObject _createdObject;
    [SerializeField] private int _creationDelay;

    private Vector2 _placeOfCreation;

    private void Start()
    {
        _placeOfCreation = new Vector2(Random.Range(-10, 80), Random.Range(40, 5));
        StartCoroutine(Creator());
        
    }

    private IEnumerator Creator()
    {
        while (true)
        {
            _placeOfCreation = new Vector2(Random.Range(-10, 80), Random.Range(40, 5));
            Instantiate(_createdObject, _placeOfCreation, Quaternion.identity);
            yield return new WaitForSeconds(_creationDelay);
        }
    }

}
