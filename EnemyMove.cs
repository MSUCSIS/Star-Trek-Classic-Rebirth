using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
/*
	Transform player;			//referance to player's position
	PlayerHealth playerHealth;	//referance player's health script
	EnemyHealth enemyHealth;	//referance to this enemy's health
	NavMeshAgent nav;

	void Awake ()
	{
		//set up referances
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.GetComponent <PlayerHealth> ();
		enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}

	void Update ()
	{
		//if enemy and player have health left
		if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0) 
		{
			//set the destination of the nav mesh agent to the player
			nav.SetDestination (player.position);
		}
		//otherwise...
		else
		{
			//...disable nav mesh agent
			nav.enabled = false;
		}
	}
*/}
