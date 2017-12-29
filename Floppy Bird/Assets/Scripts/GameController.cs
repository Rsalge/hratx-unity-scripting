﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject gameOverText;
	public bool gameOver;
	public static GameController instance;
    public float scrollSpeed = -1.5f;

    // Use this for initialization
    void Awake ()
	{
		if (instance == null)
		{
			instance = this;
		} else if (instance != null)
		{
			Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameOver == true && Input.GetMouseButtonDown (0))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void BirdDied ()
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
