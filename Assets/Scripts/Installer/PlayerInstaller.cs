using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
		Container.Bind<PlayerHealth>().FromComponentInHierarchy().AsSingle();
		Container.Bind<PlayerController>().FromComponentInHierarchy().AsSingle();
	}
}