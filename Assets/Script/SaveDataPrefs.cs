using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveDataPrefs : MonoBehaviour
{
    public UIGenerator ug;
    public TypingEffectJson tej;
    public SceneChange sc1;
    public SceneChange sc2;
    public Text inputChoice1;
    public Text inputChoice2;

    public void Save()
    {
        PlayerPrefs.SetInt("Mental", ug.mentalDamage);
        PlayerPrefs.SetInt("Hp", ug.heartDamage);
        PlayerPrefs.SetString("C1", inputChoice1.text);
        PlayerPrefs.SetString("C2", inputChoice2.text);
        PlayerPrefs.SetString("Serif", tej.serif);
        PlayerPrefs.SetInt("Count", tej.count);
        PlayerPrefs.SetString("SC1", sc1.scenename);
        PlayerPrefs.SetString("SC2", sc2.scenename);

    }


    // Start is called before the first frame update
    void Start()
    {
        ug = GameObject.Find("UI").GetComponent<UIGenerator>();
        tej = GameObject.Find("Canvas").GetComponent<TypingEffectJson>();
        //sc1 = GameObject.Find("Choice1").GetComponent<SceneChange>();
        //sc2 = GameObject.Find("Choice2").GetComponent<SceneChange>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Save");
            Save();
        }
    }
}
