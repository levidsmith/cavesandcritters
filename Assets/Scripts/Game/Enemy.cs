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

    public List<GameObject> models;

    public GameObject model;

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
            Player player = GameObject.FindFirstObjectByType<Player>();
            player.iExp += enemyattributes.iExperience;
            player.iCoin += 5;
        }

        float fRotateSpeed = 30f;
        model.transform.Rotate(Vector3.up, fRotateSpeed * Time.deltaTime, Space.World);


    }


}
