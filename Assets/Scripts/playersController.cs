using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playersController : MonoBehaviour {
	List<GameObject> players;
	GameObject nextPlayer;
	public GameObject WinText;
    public Text score;
    int playerCountStart = 0;
    int playerCountCurrent = 0;

    // Use this for initialization
    void Start () {
		
		players = new List<GameObject>(GameObject.FindGameObjectsWithTag("Player"));
		players.Add(GameObject.FindGameObjectWithTag("Richard"));
        playerCountStart = players.Count();
        UpdateScore();
		NextPlayer ();
	}
		
	void Update() {
		if (Input.GetKey ("escape")) {
			Application.Quit ();
		}
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
		if (Input.GetKey (KeyCode.P)) {
			players.ForEach (x => { 
				playercontroller pc = x.GetComponent<playercontroller> ();
				pc.enabled = true;
			});
		}

	}

    void UpdateScore() {

        score.text = "Employees Saved: " + playerCountCurrent + "/" + playerCountStart;
    }

    void PlayerSaved() {
        playerCountCurrent++;
        UpdateScore();
        Invoke("NextPlayer", 1f);
    }

	void NextPlayer(){
		if (players.Count < 1) {
			YouWin ();
			return;
		}
		nextPlayer = players [0];
		players.RemoveAt (0);
		playercontroller pc = nextPlayer.GetComponent<playercontroller> ();
		pc.enabled = true;
	}

	void YouWin(){
		WinText.SetActive (true);
	}
}
