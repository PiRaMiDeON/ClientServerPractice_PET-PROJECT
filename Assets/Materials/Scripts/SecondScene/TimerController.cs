using UnityEngine;

public class TimerController : MonoBehaviour
{
    private float _playTime;
    private int _finishTime;
    private int _bestTime;
    private bool _playerFinished;

    private void Update()
    {
        if (!_playerFinished)
        {
            _playTime += Time.deltaTime;
            _finishTime = (int)(_playTime % 60);
        }
    }

    public float ReturnPlayTime()
    {
        if (PlayerPrefs.GetInt("BestTime") > _finishTime || PlayerPrefs.GetInt("BestTime") == 0)
            PlayerPrefs.SetInt("BestTime", _finishTime);
            
        return _finishTime;
    }

    public void StopTimer()
    {
        _playerFinished = true;
    }
}
