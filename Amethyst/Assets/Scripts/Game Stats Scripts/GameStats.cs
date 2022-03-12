using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
	public static int currentHealth;
	public static int numberOfGemsCollected;

	public  HealthBar healthBar;

	public GameObject[] gems;


	// Start is called before the first frame update
	void Start()
	{
		currentHealth = 100;

		for (int i = 0; i < gems.Length; i++)
        {
			gems[i].SetActive(false);
		}

		healthBar.SetHealth(currentHealth);
	}

	// Update is called once per frame
	void Update()
	{
		// We will replace this with enemy actions
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(10);
		}

		// We will replace this with enemy actions
		if (Input.GetKeyDown(KeyCode.G))
		{
			UpdateGemsNumberAndRender();
		}

		// We will replace this with enemy actions
		if (Input.GetKeyDown(KeyCode.B))
		{
			TakeHeath(10);
		}

		healthBar.SetHealth(currentHealth);
		UpdateGemsNumberAndRender();
	}

	void TakeDamage(int damage)
	{
		if (currentHealth > 0)
		{
			currentHealth -= damage;
		}

		healthBar.SetHealth(currentHealth);
	}

	void UpdateGemsNumberAndRender()
	{

		for (int i = 0; i < gems.Length; i++)
		{
			gems[i].SetActive(false);
		}

		for (int i = 0; i < numberOfGemsCollected; i++)
		{
			gems[i].SetActive(true);
		}

	}

	public void TakeHeath(int damage)
	{
		if (currentHealth < 100)
		{
			currentHealth += damage;
		}

		healthBar.SetHealth(currentHealth);
	}

	
}
