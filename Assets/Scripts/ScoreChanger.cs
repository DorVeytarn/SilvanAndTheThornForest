using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField] private int _pointValue;

    private int _currentScore;
    private Text _scoreText;

    private void Start()
    {
        _scoreText = GetComponent<Text>();
    }

    public void ScoreUp()
    {
        _currentScore += _pointValue;
        _scoreText.text = "Ваш счёт: " + _currentScore;
    }
}
