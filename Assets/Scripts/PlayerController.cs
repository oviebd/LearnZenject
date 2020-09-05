using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class PlayerController : MonoBehaviour
{
	//[Inject]
	PlayerHealth health;

	[Inject]
	void Construct(PlayerHealth h)
	{
		h.healthAmount = Random.Range(0, 100);
		health = h;
	}

    void Start()
    {
		health.ShowHealth();
    }

    // Update is called once per frame
   public string GetPlayerName()
	{
		return this.gameObject.name;
	}

	public class Factory : PlaceholderFactory<PlayerController> { }
}
