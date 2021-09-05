
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float[] _posX;
    [SerializeField] private bool _isHit;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 _mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            transform.position.y,
            transform.position.z
        ));

        if(Input.GetMouseButtonDown(0) && _isHit == true && _mousePos.x >= _posX[0] && _mousePos.x <= _posX[1]) {
            rb.velocity = new Vector2(
                    _moveSpeed,
                    rb.velocity.y
            );
            _isHit = false;
            if(!_isHit) _moveSpeed *= -1; 
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Middle")) {
            _isHit = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Triangle")) {
            gameManager.GameOver();
        }

        if(other.gameObject.CompareTag("Score")) {
            gameManager._score ++;
        }
    }
}
