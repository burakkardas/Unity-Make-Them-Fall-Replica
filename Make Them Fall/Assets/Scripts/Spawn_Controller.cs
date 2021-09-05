using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controller : MonoBehaviour
{
    [SerializeField] private GameObject _trianglePref;
    [SerializeField] private float[] _posX;
    [SerializeField] private float _duration;
    [SerializeField] private float _currentTime;
    void Start()
    {
        
    }

    void Update()
    {
        if(_currentTime <= 0) {
            _currentTime = _duration;
            Spawn();
        }
        else {
            _currentTime -= Time.deltaTime;
        }
    }

    public void Spawn() {
        GameObject _newTriangle = Instantiate(_trianglePref);
        _newTriangle.transform.position = new Vector2(
            _posX[Random.Range(0, _posX.Length)],
            transform.position.y
        );

        _newTriangle.transform.SetParent(transform);

        if(_newTriangle.transform.position.x == _posX[1]) {
            _newTriangle.transform.localScale = new Vector3(_newTriangle.transform.localScale.x * -1, 0.4f, 0f);
        }
    }
}
