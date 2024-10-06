//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public Text textName;
    public Text textHitPoints;

    public EnemyAttributes enemyattributes;
    public int iHitPoints;

    // Start is called before the first frame update
    void Start() {
        iHitPoints = enemyattributes.iHitPoints;

        
    }

    // Update is called once per frame
    void Update() {
        textName.text = enemyattributes.strName;
        textHitPoints.text = string.Format("{0}", iHitPoints);

        if (iHitPoints <= 0) {
            Destroy(this.gameObject);
        }


    }
}
