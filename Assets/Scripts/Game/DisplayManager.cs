//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour {
    public GameObject PanelVictory;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void showVictoryPanel() {
        PanelVictory.SetActive(true);
    }

    public void hideVictoryPanel() {
        PanelVictory.SetActive(false);

    }
}
