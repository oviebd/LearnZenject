using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
	public PlayerController pcPrefab;
	public override void InstallBindings()
    {
		//	Container.Bind<PlayerHealth>().FromComponentInHierarchy().AsSingle();
		//Container.Bind<PlayerController>().AsSingle();

		Container.BindFactory<PlayerController, PlayerController.Factory>().FromComponentInNewPrefab(pcPrefab);
    }
}