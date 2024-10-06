//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour {
    public GameObject PanelVictory;
    public Material matBackground;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        matBackground.SetTextureOffset("_MainTex", new Vector2(0f, Time.time * 0.1f));

    }

    public void showVictoryPanel() {
        PanelVictory.SetActive(true);
    }

    public void hideVictoryPanel() {
        PanelVictory.SetActive(false);

    }
}
