using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDataPrefs : MonoBehaviour
{
    public UIGenerator ug;
    public TypingEffectJson tej;
    public SceneChange sc1;
    public SceneChange sc2;
    public Text inputChoice1;
    public Text inputChoice2;
    public ChangeImage ci;
    public Achieve a1;
    public Achieve a2;

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }

    public void Load()
    {
        Debug.Log("Load");
        if (PlayerPrefs.HasKey("Hp"))
        {
            ug.heartDamage = PlayerPrefs.GetInt("Hp");
            ug.mentalDamage = PlayerPrefs.GetInt("Mental");
        }
        
        if (PlayerPrefs.HasKey("C1"))
        {
            inputChoice1.text = PlayerPrefs.GetString("C1");
            inputChoice2.text = PlayerPrefs.GetString("C2");
        }

        if (PlayerPrefs.HasKey("Serif"))
        {
            tej.serif = PlayerPrefs.GetString("Serif");
            tej.count = PlayerPrefs.GetInt("Count");
            tej.scenename = PlayerPrefs.GetString("Scenename");
            tej.nextchaptercheck = intToBool(PlayerPrefs.GetInt("Next"));
        }

        if (PlayerPrefs.HasKey("SC1"))
        {
            sc1.scenename = PlayerPrefs.GetString("SC1");
            sc2.scenename = PlayerPrefs.GetString("SC2");
        }

        if (PlayerPrefs.HasKey("Image"))
        {
            ci.pnum = PlayerPrefs.GetInt("Image");
            tej.changenumber1 = PlayerPrefs.GetInt("Changenumber1");
            tej.changenumber2 = PlayerPrefs.GetInt("Changenumber2");
            tej.changenumber3 = PlayerPrefs.GetInt("Changenumber3");
            tej.changenumber4 = PlayerPrefs.GetInt("Changenumber4");
            tej.changenumber5 = PlayerPrefs.GetInt("Changenumber5");
            tej.wantimagenumber1 = PlayerPrefs.GetInt("Wantnumber1");
            tej.wantimagenumber2 = PlayerPrefs.GetInt("Wantnumber2");
            tej.wantimagenumber3 = PlayerPrefs.GetInt("Wantnumber3");
            tej.wantimagenumber4 = PlayerPrefs.GetInt("Wantnumber4");
            tej.wantimagenumber5 = PlayerPrefs.GetInt("Wantnumber5");
        }
        if (PlayerPrefs.HasKey("Achname1"))
        {
            a1.achname = PlayerPrefs.GetString("Achname1");
            a2.achname = PlayerPrefs.GetString("Achname2");
            a1.achinum = PlayerPrefs.GetInt("Achinum1");
            a2.achinum = PlayerPrefs.GetInt("Achinum2");
            a1.achipath = PlayerPrefs.GetString("Achipath1");
            a2.achipath = PlayerPrefs.GetString("Achipath2");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        ug = GameObject.Find("UI").GetComponent<UIGenerator>();
        tej = GameObject.Find("Canvas").GetComponent<TypingEffectJson>();
        sc1 = GameObject.Find("Choice1").GetComponent<SceneChange>();
        sc2 = GameObject.Find("Choice2").GetComponent<SceneChange>();
        ci = GameObject.Find("Image").GetComponent<ChangeImage>();
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
