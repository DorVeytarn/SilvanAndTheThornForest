using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed; 
    [SerializeField] private float _jumpForce; 

    private Animator _playerAnimator;
    private Rigidbody2D _rb2d;
    private bool _isGrounded;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        _rb2d.velocity = new Vector2(moveHorizontal * _speed, _rb2d.velocity.y);

   
        if (moveHorizontal >= 0.3f || moveHorizontal <= -0.3f)
            _playerAnimator.SetBool("isMoving", true);
        else if (moveHorizontal < 0.3f && moveHorizontal > 0 || moveHorizontal > -0.3f && moveHorizontal <0)
            _playerAnimator.SetBool("isMoving", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, 0);
            _rb2d.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Ground ground))
        {
            _isGrounded = true;
            _playerAnimator.SetBool("isGrounded", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Ground ground))
        {
            _isGrounded = false;
            _playerAnimator.SetBool("isGrounded", false);
        }
    }
}
