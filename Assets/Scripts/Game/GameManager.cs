//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void doBattle() {
        SceneManager.LoadScene("battle");

    }

    public void doQuit() {
        SceneManager.LoadScene("title");
    }

    public void doEquip() {
        SceneManager.LoadScene("equip");
    }
}
