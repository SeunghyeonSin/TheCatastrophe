using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
    //싱글톤으로 선언
    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    static DataController _instance;
    public static DataController Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }

    //게임 데이터 파일이름 설정
    public string GameDataFileName = "SaveData.json";
    public GameData _gameData;
    public GameData gameData
    {
        get
        {
            //게임이 시작되면 자동으로 실행되도록
            if(_gameData == null)
            {
                LoadGameData();
                SaveGameData();
            }
            return _gameData;
        }
    }

    private void Start()
    {
        LoadGameData();
        SaveGameData();
    }

    //저장된 게임 불러오기
    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + GameDataFileName;
        //저장된 게임이 있다면
        if(File.Exists(filePath))
        {
            Debug.Log("불러오기 성공");
            string FromJsonData = File.ReadAllText(filePath);
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }
        //저장 된 게임이 없다면
        else
        {
            Debug.Log("새로운 파일 생성");
            _gameData = new GameData();
        }
    }

    //게임 저장하기
    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(gameData);
        string filePath = Application.persistentDataPath + GameDataFileName;
        //이미 저장된 파일이 있다면 덮어쓰기
        File.WriteAllText(filePath, ToJsonData);
        //올바르게 저장됐는지 확인
        Debug.Log("저장완료");
        //Debug.Log("2는 " + gameData.isClear2);
        //Debug.Log("3는 " + gameData.isClear3);
    }
    //챕터 잠금 해제
    /*public void ChapterUnlock(int chapterNumber)
    {
        switch (chapterNumber)
        {
            case 2:
                isClear2 = true;
                dataCtrl.gameData.isClear2 = isClear2;
                dataCtrl.SaveGameData();
                break;
            case 3:
                isClear3 = true;
                dataCtrl.gameData.isClear3 = isClear3;
                dataCtrl.SaveGameData();
                break;
        }
    }*/
    //게임을 종료하면 자동저장되도록
    private void OnApplicationQuit()
    {
        SaveGameData();
    }
}
