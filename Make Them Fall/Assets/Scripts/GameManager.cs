using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    public int _score;
    void Start()
    {
        
    }

    void Update()
    {
        _scoreText.text = _score.ToString();
    }

    public void GameOver() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
