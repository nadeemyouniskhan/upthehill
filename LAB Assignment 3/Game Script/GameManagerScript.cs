using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

	

	[SerializeField]
	public GameObject PausePanel, GameOverPanel;

	[SerializeField]
	public Button PauseButton, resumeButton, playAgainButton, gotoMenuButton;

	public Text scoreText, coinScore, bestScore, highCoinScore, gameOverBestScore, gameOverHighCoinScore;

	[SerializeField]
	public Text newHighScoreText, newHighCoinText;

	[SerializeField]
	public Image highScoresImage;

	public AudioSource audioSource;
	public AudioClip cheerClip;

	public Transform groundGenerator;
	private Vector3 groundStartPoint;

	public CarController player;
	private Vector3 playerStartPoint;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void RestartGame () {
		StartCoroutine ("RestartGameCoroutine");
	}

	public IEnumerator RestartGameCoroutine() {
		player.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		
		
		player.gameObject.SetActive (true);
	}

	public void pauseGame () {
		PausePanel.SetActive (true);
		
		Time.timeScale = 0f;
	}

	public void resumeGame () {
		PausePanel.SetActive (false);
		
		Time.timeScale = 1f;
	}

	public void playAgain () {
		Time.timeScale = 1f;
		PauseButton.gameObject.SetActive (true);
		SceneManager.LoadScene ("Gameplay");
		GameOverPanel.SetActive (false);
	}

	public void gotoMenu () {
		SceneManager.LoadScene ("Main");
	}

	public void SetCoinScore (int score) {
		coinScore.text = "Coin: " + score;
	}

	public void SetScore () {
		
	}

	public void gameOver (int score, int coins) {
		coinScore.gameObject.SetActive (false);
		PauseButton.gameObject.SetActive (false);
		GameOverPanel.SetActive (true);
		gameOverBestScore.text = "Your Score: " + score;
		gameOverHighCoinScore.text = "Your Coin Score: " + coins;

	}

	

	
		
}

















