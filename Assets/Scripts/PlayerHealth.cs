using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;

    private Animator _playerAnimator;

    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            _playerAnimator.SetBool("isDead", true);
            StartCoroutine(Die(gameObject, 1f));
        }
    }
    
    private IEnumerator Die(GameObject gameObject, float secondsDelay)
    {
        yield return new WaitForSeconds(secondsDelay);
        Destroy(gameObject);
    }

}
