using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameManager : MonoBehaviour
{
	[Inject]
	PlayerController.Factory playerControllerFactory;

	public GameObject prefab;

	float delay = 1.0f;
	float lastTime;

	void InstantiateObj()
	{
		PlayerController pc = playerControllerFactory.Create();
	}

   
    void Update()
    {
        if(Time.time - lastTime >= delay)
		{
			lastTime = Time.time;
			InstantiateObj();
		}
    }
}
