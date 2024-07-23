using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;
using TMPro;
public class Finish : MonoBehaviour
{
    [SerializeField] private int _sceneIndex;
    [SerializeField] private Animator _animator;
    [Inject] AnimationClip _animationClip;
    [Inject] private TimerController _timerController;
    [Inject] private TMP_Text _text;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            _timerController.StopTimer();
            _animator.SetTrigger("Spawn");
            _text.text = $"{ _timerController.ReturnPlayTime().ToString()} Seconds \n Best time: {PlayerPrefs.GetInt("BestTime").ToString()}s";

            yield return new WaitForSeconds(_animationClip.length * 5);

            SceneManager.LoadScene(_sceneIndex);
        }
    }
}
