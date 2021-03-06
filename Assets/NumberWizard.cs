﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed = 5;

	public Text text; 
	
	void Start () {
		StartGame();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		text.text = guess.ToString();
	}

	public void GuessHigher () {
		min = guess;
		NextGuess();
	}

	public void GuessLower () {
		max = guess;
		NextGuess();
	}

	void NextGuess () {
		guess = (max + min) / 2;
		text.text = guess.ToString();
		maxGuessesAllowed -= 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}