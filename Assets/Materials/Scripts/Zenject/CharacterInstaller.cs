using UnityEngine;
using Zenject;

public class CharacterInstaller : MonoInstaller
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private AnimatorController _animatorController;
    [SerializeField] private Animator _animator;
    public override void InstallBindings()
    {
        Container.Bind<Rigidbody>().FromInstance(_rigidbody);
        Container.Bind<AnimatorController>().FromInstance(_animatorController);
        Container.Bind<Animator>().FromInstance(_animator);
    }
}