using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;							//player's starting health
	public int currentHealth;									//Player's current health
	public Slider healthSlider;									//Referance to UI's health slider
	public Image damageImage;									//referance to show damage
	public AudioClip deathClip;									//Player dies sound
	public float flashSpeed = 5f;								//damageImage flash speed
	public Color FlashColor = new Color (1f, 0f, 0f, 0.1f);		//color of flash set in engine

	
}
