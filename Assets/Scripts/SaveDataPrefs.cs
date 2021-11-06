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
    public ChangeImage ci;

    public void AutoSave()
    {
        Debug.Log("AutoSave");
        PlayerPrefs.SetInt("Mental", ug.mentalDamage);
        PlayerPrefs.SetInt("Hp", ug.heartDamage);
        PlayerPrefs.SetString("C1", inputChoice1.text);
        PlayerPrefs.SetString("C2", inputChoice2.text);
        PlayerPrefs.SetString("Serif", tej.serif);
        PlayerPrefs.SetInt("Count", tej.count);
        PlayerPrefs.SetString("SC1", sc1.scenename);
        PlayerPrefs.SetString("SC2", sc2.scenename);
        PlayerPrefs.SetInt("Image", ci.pnum);
        PlayerPrefs.SetInt("Changenumber1", tej.changenumber1);
        PlayerPrefs.SetInt("Changenumber2", tej.changenumber2);
        PlayerPrefs.SetInt("Changenumber3", tej.changenumber3);
        PlayerPrefs.SetInt("Wantnumber1", tej.wantimagenumber1);
        PlayerPrefs.SetInt("Wantnumber2", tej.wantimagenumber2);
        PlayerPrefs.SetInt("Wantnumber3", tej.wantimagenumber3);

    }

    public void Save()
    {
        Debug.Log("Save");
        PlayerPrefs.SetInt("Mental", ug.mentalDamage);
        PlayerPrefs.SetInt("Hp", ug.heartDamage);
        PlayerPrefs.SetString("C1", inputChoice1.text);
        PlayerPrefs.SetString("C2", inputChoice2.text);
        PlayerPrefs.SetString("Serif", tej.serif);
        PlayerPrefs.SetInt("Count", tej.count);
        PlayerPrefs.SetString("SC1", sc1.scenename);
        PlayerPrefs.SetString("SC2", sc2.scenename);
        PlayerPrefs.SetInt("Changenumber1", tej.changenumber1);
        PlayerPrefs.SetInt("Changenumber2", tej.changenumber2);
        PlayerPrefs.SetInt("Changenumber3", tej.changenumber3);
        PlayerPrefs.SetInt("Wantnumber1", tej.wantimagenumber1);
        PlayerPrefs.SetInt("Wantnumber2", tej.wantimagenumber2);
        PlayerPrefs.SetInt("Wantnumber3", tej.wantimagenumber3);
    }


    // Start is called before the first frame update
    void Start()
    {
        ug = GameObject.Find("UI").GetComponent<UIGenerator>();
        tej = GameObject.Find("Canvas").GetComponent<TypingEffectJson>();
        ci = GameObject.Find("Image").GetComponent<ChangeImage>();
        //sc1 = GameObject.Find("Choice1").GetComponent<SceneChange>();
        //sc2 = GameObject.Find("Choice2").GetComponent<SceneChange>();
        AutoSave();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Save();
        }
    }
}
