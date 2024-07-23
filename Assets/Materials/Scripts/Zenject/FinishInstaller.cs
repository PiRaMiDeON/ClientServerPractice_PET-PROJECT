using UnityEngine;
using Zenject;
using TMPro;

public class FinishInstaller : MonoInstaller
{ 
    [SerializeField] private AnimationClip _animationClip;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TimerController _timerController; 

    public override void InstallBindings()
    {
        Container.Bind<AnimationClip>().FromInstance(_animationClip);
        Container.Bind<TMP_Text>().FromInstance(_text);
        Container.Bind<TimerController>().FromInstance(_timerController);
    }
}