using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;

public class TextLoadTest : MonoBehaviour
{
    //데이터를 담을 딕셔너리 선언
    public Dictionary<int, TextLoadTest> dicTextLoadText;

    //엑셀에서 만든 변수 선엄
    public int id;
    public string text;

    //텍스트 데이터를 표시할 라벨
    public Text label;

    private int dex;
    
    // Start is called before the first frame update
    void Start()
    {
        this.dicTextLoadText = new Dictionary<int, TextLoadTest>();
        this.dex = 101;

        var oj = Resources.Load("Data/test") as TextAsset;
        
        var jlist = JsonConvert.DeserializeObject<List<TextLoadTest>>(oj.text);

        //각각의 내용들을 딕셔너리에 담음
        foreach(var data in jlist)
        {
            this.dicTextLoadText.Add(data.id, data);
        }
    }

    //텍스트를 집어넣는 메서드
    public void ShowText()
    {
        label.text = this.dicTextLoadText[dex].text;
        //this.dex += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //this.OnGUI();
            if (dex <= 112)
            {
                this.ShowText();
                Debug.Log(dex);
                this.dex += 1;
            }
        }
    }
}
