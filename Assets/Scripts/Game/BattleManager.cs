//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour {

    public GameObject EnemyPrefab;
    public YamlParser yamlparser;
    public List<EnemyAttributes> enemyattributes;
    public GameObject objRoom;
    public DisplayManager displaymanager;


    // Start is called before the first frame update
    void Start() {
        enemyattributes = new List<EnemyAttributes>();
        yamlparser.parseEnemies(enemyattributes);

        Debug.Log(enemyattributes[0].strName);

        startBattle();
        
    }

    // Update is called once per frame
    void Update() {
        if (objRoom.transform.childCount == 0) {
            displaymanager.showVictoryPanel();

        }


        
    }

    public void startBattle() {
        int iRand;

        iRand = Random.Range(0, enemyattributes.Count);

        Enemy enemy = Instantiate(EnemyPrefab, Vector3.zero, Quaternion.identity).GetComponent<Enemy>();
        enemy.enemyattributes = enemyattributes[iRand];

        enemy.model = enemy.models[iRand];
        enemy.models[iRand].SetActive(true);
        //Debug.Log(enemyattributes[0].strName);

        enemy.transform.SetParent(objRoom.transform);

    }

    public void doAttack() {
        Enemy enemy = GameObject.FindObjectOfType<Enemy>();
        enemy.iHitPoints -= 1;

    }

    public void doVictoryContinue() {
        SceneManager.LoadScene("cave");
    }

    public void doRun() {
        SceneManager.LoadScene("cave");
    }
}
