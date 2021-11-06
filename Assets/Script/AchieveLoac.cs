using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.SceneManagement;
using LitJson;

public class AchieveLoac : MonoBehaviour
{
    public Text JsonText;

    //업적 파일 경로
    public string LoadAchi;

    // Start is called before the first frame update
    void Start()
    {
        string Jsonstring = File.ReadAllText(Application.dataPath + LoadAchi);
        JsonData Jsondata = JsonMapper.ToObject(Jsonstring);
        //Debug.Log(Jsonstring);

        //JsonText.text = Jsonstring;
        JsonText.text = Jsondata["AchieveTEXT"].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape)) //뒤로가기 키 입력
            {
                Debug.Log("SceneChange!!");
                SceneManager.LoadScene("Main");
            }

        }
    }
}
