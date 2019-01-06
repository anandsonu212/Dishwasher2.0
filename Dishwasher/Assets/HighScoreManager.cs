using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;


public class HighScoreManager : MonoBehaviour {


    public Text showscore;

    // Use this for initialization
    void Start() {
        showscore.text = "Score: " + PlayerPrefs.GetInt("YourScore");

    }
    public void replay(){
        PlayerPrefs.SetInt("YourScore", 0);
        SceneManager.LoadScene("Second");
    }

    public void exit(){
        resetAll();
        SceneManager.LoadScene("login");
    }
    private void resetAll()
    {
        PlayerPrefs.DeleteAll();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
