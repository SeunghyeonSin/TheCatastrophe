using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.IO;
using System;
using Newtonsoft.Json;

//����
public class AchieveInfo
{
    public int AchieveID;
    public string AchieveTEXT;

    public AchieveInfo(int id, string text)
    {
        AchieveID = id;
        AchieveTEXT = text;
    }
}

public class Achieve : MonoBehaviour
{
    //������ ���� ����
    public string achname;
    public int achinum;

    //���� ���
    public string achipath;

    //������ Ŭ���� ���� ���� ����
    public void SaveAchieveInfo()
    {
        AchieveInfo achieveinfoData = new AchieveInfo(achinum, achname);

        Debug.Log("Save AchieveInfo");

        JsonData infoJson = JsonMapper.ToJson(achieveinfoData);

        File.WriteAllText(Application.dataPath + achipath, infoJson.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
