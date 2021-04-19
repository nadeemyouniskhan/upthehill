using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    public GameObject instructionPanel;

    [SerializeField]
    public Button playButton, menuButton, quitButton; //, closeButton;

    [SerializeField]
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
	public void playGame()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Gameplay");
	}

	public void instructionMenu()
	{
		instructionPanel.SetActive(true);
		
		playButton.gameObject.SetActive(false);
		quitButton.gameObject.SetActive(false);
		menuButton.gameObject.SetActive(false);
		
		image.SetActive(false);
	}

	public void quitGame()
	{
		Application.Quit();
	}

	public void closeInstruction()
	{
		instructionPanel.SetActive(false);
		playButton.gameObject.SetActive(true);
		quitButton.gameObject.SetActive(true);
		menuButton.gameObject.SetActive(true);
		image.SetActive(true);
	}
}
