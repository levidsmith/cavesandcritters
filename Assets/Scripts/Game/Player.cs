//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int iStrength;
    public int iDexterity;
    public int iConstitution;
    public int iIntelligence;
    public int iWisdom;
    public int iCharisma;

    public int iHitPoints;
    public int iMaxHitPoints;

    public int iGold;
    public int iExperience;

    // Start is called before the first frame update
    void Start() {
        iMaxHitPoints = 20;
        iHitPoints = iMaxHitPoints;
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
