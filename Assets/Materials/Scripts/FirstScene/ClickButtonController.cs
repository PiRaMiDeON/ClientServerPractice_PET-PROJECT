using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickButtonController : MonoBehaviour
{
    public TMP_Text _currentScoreValueText;
    public TMP_Text _bestScoreValueText;

    private int _currentScore = 0;

    private void Awake()
    {
        _bestScoreValueText.text = PlayerPrefs.GetInt("BestScore").ToString();
    }
    public void Click()
    {
        _currentScore += 1;
        _currentScoreValueText.text = _currentScore.ToString();

        if (_currentScore > PlayerPrefs.GetInt("BestScore"))
            PlayerPrefs.SetInt("BestScore", _currentScore);
    }
}
