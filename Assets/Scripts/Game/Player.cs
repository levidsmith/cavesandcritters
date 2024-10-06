//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public int iStrength;
    public int iDexterity;
    public int iConstitution;
    public int iIntelligence;
    public int iWisdom;
    public int iCharisma;

    public int iHitPoints;
    public int iMaxHitPoints;

    public int iCoin;
    public int iExp;

    public Text uiHitPointsValue;
    public Text uiExpValue;
    public Text uiCoinValue;



    // Start is called before the first frame update
    void Start() {
        iMaxHitPoints = 20;
        iHitPoints = iMaxHitPoints;
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update() {
        uiHitPointsValue.text = string.Format("{0}", iHitPoints);
        uiExpValue.text = string.Format("{0}", iExp);
        uiCoinValue.text = string.Format("{0}", iCoin);

    }
}
