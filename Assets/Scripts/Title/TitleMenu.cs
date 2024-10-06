//2024 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour {

    public GameObject objTitle;
    public GameObject objLight;
    public Material matBackground;

    float fLightRot = 0f;
    float fLightVel = 10f;

    float fBackgroundTextureOffset = 0f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        float objTitle_y = 0.2f;
        if (objTitle.transform.position.z < 0f) {
            float fSpeed = 2f;
            Vector3 pos = new Vector3(0f, objTitle_y, objTitle.transform.position.z + Time.deltaTime * fSpeed);
            objTitle.transform.position = pos;


        } else if (objTitle.transform.position.z > 0f) {
            Vector3 pos = new Vector3(0f, objTitle_y, 0f);
            objTitle.transform.position = pos;
        }

        if (fLightVel > 0 && fLightRot > 40f) {
            fLightVel *= -1;
        } else if (fLightVel < 0 && (fLightRot < 320f)) {
            fLightVel *= -1;
        }
        objLight.transform.Rotate(Vector3.up, fLightVel * Time.deltaTime, Space.World);

        fBackgroundTextureOffset += Time.deltaTime;
        //matBackground.SetTextureOffset(0, new Vector2(0f, fBackgroundTextureOffset));
        matBackground.SetTextureOffset("_MainTex", new Vector2(0f, Time.time * 0.1f));
        
    }

    public void doStart() {
        SceneManager.LoadScene("cave");

    }

    public void doQuit() {
        Application.Quit();
    }
}
