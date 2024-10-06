//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YamlParser : MonoBehaviour {

    public TextAsset textEnemiesYaml;

    // Start is called before the first frame update
    void Start() {
        
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void parseEnemies(List<EnemyAttributes> enemyattributes) {
        EnemyAttributes ea = null;

        string strEnemies = textEnemiesYaml.text;

        Debug.Log(strEnemies);
        foreach(string strLine in strEnemies.Split('\n')) {
            //Debug.Log(strLine);
            if (strLine.StartsWith("- enemy:")) {
                //enemy = Instantiate(EnemyPrefab, Vector3.zero, Quaternion.identity).GetComponent<Enemy>();
                ea = new EnemyAttributes();
            } else if (strLine.StartsWith("    name:")) {
                ea.strName = strLine.Substring(10);
            } else if (strLine.StartsWith("    hp:")) {
                ea.iHitPoints = int.Parse(strLine.Substring(8));
            } else if (strLine.StartsWith("    adv:")) {
                ea.iAdvantage = int.Parse(strLine.Substring(9));
            } else if (strLine.StartsWith("    speed:")) {
                ea.iSpeed = int.Parse(strLine.Substring(11));
            } else if (strLine.StartsWith("    exp:")) {
                ea.iExperience = int.Parse(strLine.Substring(9));

                enemyattributes.Add(ea);
            }
        }


    }
}
