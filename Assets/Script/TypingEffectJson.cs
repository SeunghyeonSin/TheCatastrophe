using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;

public class TypingEffectJson : MonoBehaviour
{
    //UI ���� ����
    public GameObject ui;

    //�����͸� ���� ��ųʸ� ����
    public Dictionary<int, TextLoadTest> dicTextLoadText;

    //IEnumerator ���� ����
    private IEnumerator coroutine;

    //�������� ���� ���� ����
    public int id;
    public string text;

    //�ؽ�Ʈ �����͸� ǥ���� ��
    public Text label;

    //id�� ī��Ʈ�� ���� ����
    private int dex;

    //label�� ������ ���� ����
    public string m_text;

    //if�� ���Թ���
    public bool Dnobs = true;
    public bool test = false;

    //�����ġ ���� ����
    public string serif;

    //������ ����
    public GameObject ChoicePrefab1;
    public GameObject ChoicePrefab2;
    public int count;

    //������ Ȱ��
    void ShowChoice()
    {
        if (count == this.dex)
        {
            ChoicePrefab1.SetActive(true);
            ChoicePrefab2.SetActive(true);
        }
    }

    //Ÿ����ȿ�� �޼ҵ�
    public IEnumerator _typing()
    {
        bool qw = false;
        Debug.Log("��������ȣ : " + dex);
        for (int i = 0; i <= m_text.Length; i++)
        {
            if (!Dnobs)
            {
                Debug.Log("Ÿ���� �ݺ��� ���");
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

    //�ڷ�ƾ ����
    void _readJson(int i)
    {
        m_text = this.dicTextLoadText[i].text;
        coroutine = _typing();
        StartCoroutine(coroutine);
    }

    //�ڷ�ƾ ����
    void _endJson()
    {
        StopCoroutine(coroutine);
        ShowChoice();
        test = false;
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
        //������ ��Ȱ��
        this.ChoicePrefab1 = GameObject.Find("Choice1");
        this.ChoicePrefab2 = GameObject.Find("Choice2");
        ChoicePrefab1.SetActive(false);
        ChoicePrefab2.SetActive(false);

        this.dicTextLoadText = new Dictionary<int, TextLoadTest>();
        this.dex = 1;

        var oj = Resources.Load(serif) as TextAsset;

        var jlist = JsonConvert.DeserializeObject<List<TextLoadTest>>(oj.text);

        //������ ������� ��ųʸ��� ����
        foreach (var data in jlist)
        {
            this.dicTextLoadText.Add(data.id, data);
        }
        _readJson(this.dex);

        //UI���ӿ�����Ʈ �˻�
        ui = GameObject.Find("UI");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && test == false)
        {
            Debug.Log("���콺 Ŭ��");
            Dnobs = false;
        }

        if (Input.GetMouseButtonDown(0) && test == true)
        {
            Dnobs = true;
            test = false;
            _readJson(this.dex);
        }

        if (count == this.dex)
        {
            _endJson();
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
