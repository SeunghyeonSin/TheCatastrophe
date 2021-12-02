using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using LitJson;
using System.IO;

public class TypingEffectJson : MonoBehaviour
{
    //UI 변수 선언
    public GameObject ui;

    //데이터를 담을 딕셔너리 선언
    public Dictionary<int, TextLoadTest> dicTextLoadText;

    //IEnumerator 변수 선언
    private IEnumerator coroutine;

    //엑셀에서 만든 변수 선언
    public int id;
    public string text;

    //텍스트 데이터를 표시할 라벨
    public Text label;

    //id를 카운트할 변수 선언
    private int dex;

    //label를 저장할 변수 선언
    public string m_text;

    //if문 진입방지
    public bool Dnobs = true;
    public bool test = false;

    //대사위치 변수 선언
    public string serif;

    //선택지 선언
    public GameObject ChoicePrefab1;
    public GameObject ChoicePrefab2;
    public GameObject ChoicePrefabImage;
    public int count;

    //이미지변경 카운트 선언
    public ChangeImage ci;
    public int changenumber1;
    public int changenumber2;
    public int changenumber3;
    public int changenumber4;
    public int changenumber5;
    public int wantimagenumber1;
    public int wantimagenumber2;
    public int wantimagenumber3;
    public int wantimagenumber4;
    public int wantimagenumber5;

    //다음챕터 넘어가기
    public string scenename;
    public bool nextchaptercheck = false;

    //배경음 제어
    private GameObject Music;

    //이미지변경 카운트 세기
    void CountChangeImage()
    {
        if (changenumber1 == dex)
        {
            ci.pnum = wantimagenumber1; //바꿀 이미지 번호
            ci.NextImage();
            Debug.Log("원하는 첫번째 사진");
        }
        else if (changenumber2 == dex)
        {
            ci.pnum = wantimagenumber2; //바꿀 이미지 번호
            ci.NextImage();
            Debug.Log("원하는 두번째 사진");
        }
        else if (changenumber3 == dex)
        {
            ci.pnum = wantimagenumber3; //바꿀 이미지 번호
            ci.NextImage();
            Debug.Log("원하는 세번째 사진");
        }
        else if (changenumber4 == dex)
        {
            ci.pnum = wantimagenumber4; //바꿀 이미지 번호
            ci.NextImage();
            Debug.Log("원하는 네번째 사진");
        }
        else if (changenumber5 == dex)
        {
            ci.pnum = wantimagenumber5; //바꿀 이미지 번호
            ci.NextImage();
            Debug.Log("원하는 다섯번째 사진");
        }

    }

    //선택지 활성
    void ShowChoice()
    {
        if (count == this.dex)
        {
            ChoicePrefab1.SetActive(true);
            ChoicePrefab2.SetActive(true);
            ChoicePrefabImage.SetActive(true);
        }
    }

    //타이핑효과 메소드
    public IEnumerator _typing()
    {
        bool qw = false;
        Debug.Log("페이지번호 : " + dex);
        for (int i = 0; i <= m_text.Length; i++)
        {
            if (!Dnobs)
            {
                Debug.Log("타이핑 반복문 취소");
                _endtyping();
                qw = true;
                yield break;
            }
            label.text = m_text.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }

        if(!qw)
        { 
            this.dex++;
            test = true;
        }
        
    }

    //코루틴 시작
    void _readJson(int i)
    {
        m_text = this.dicTextLoadText[i].text;
        coroutine = _typing();
        StartCoroutine(coroutine);
    }

    //코루틴 종료
    void _endJson()
    {
        StopCoroutine(coroutine);
        test = false;
        if (nextchaptercheck == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(scenename);
                GameObject.Destroy(Music);
                Debug.Log("Music OFF");

            }
        }
        else if (Input.GetMouseButtonDown(0))
            ShowChoice();
    }

    void _endtyping()
    {
        label.text = m_text;
        Debug.Log("EndTyping");
        Dnobs = true;
        this.dex++;
        test = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        //이미지 스크립트 선언
        ci = GameObject.Find("Image").GetComponent<ChangeImage>();

        //선택지 비활성
        this.ChoicePrefab1 = GameObject.Find("Choice1");
        this.ChoicePrefab2 = GameObject.Find("Choice2");
        this.ChoicePrefabImage = GameObject.Find("ChoiceBackImage");
        ChoicePrefab1.SetActive(false);
        ChoicePrefab2.SetActive(false);
        ChoicePrefabImage.SetActive(false);

        this.dicTextLoadText = new Dictionary<int, TextLoadTest>();
        this.dex = 1;

        TextAsset oj = (TextAsset)Resources.Load(serif, typeof(TextAsset));
        var jlist = JsonConvert.DeserializeObject<List<TextLoadTest>>(oj.text);

        //각각의 내용들을 딕셔너리에 담음
        foreach (var data in jlist)
        {
            this.dicTextLoadText.Add(data.id, data);
        }
        _readJson(this.dex);

        //UI게임오브젝트 검색
        ui = GameObject.Find("UI");
        //뮤직오브젝트 검색
        Music = GameObject.Find("backgroundMusic");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && test == false)
        {
            Debug.Log("마우스 클릭");
            Dnobs = false;
        }

        if (Input.GetMouseButtonDown(0) && test == true)
        {
            Dnobs = true;
            test = false;
            _readJson(this.dex);
            CountChangeImage();
        }

        if (count == this.dex)
        {
            _endJson();
        }

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape)) //뒤로가기 키 입력
            {
                Debug.Log("SceneChange!!");
                SceneManager.LoadScene("Main");
                Debug.Log("Destroy");
                GameObject.Destroy(ui);
            }

        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("SceneChange!!");
            SceneManager.LoadScene("Main");
            Debug.Log("Destroy");
            GameObject.Destroy(ui);
        }
    }
}
