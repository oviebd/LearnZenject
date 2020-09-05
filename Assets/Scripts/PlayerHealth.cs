using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class PlayerHealth : MonoBehaviour
{
	public int healthAmount = 100;

	[Inject]
	PlayerController pc;

	public void ShowHealth()
	{
		Debug.Log("Current Health 0f " + pc.GetPlayerName() + "  is  " + healthAmount);
	}

	public void IncreaseDecreaseHealth(int amount)
	{
		healthAmount = healthAmount + amount;
		ShowHealth();
	}

}
