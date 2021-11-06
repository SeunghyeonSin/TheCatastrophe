using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSimpleData : MonoBehaviour
{
    public UIGenerator ug;

    public void Load()
    {
        Debug.Log("Load");
        if (PlayerPrefs.HasKey("Hp"))
        {
            ug.heartDamage = PlayerPrefs.GetInt("Hp");
            ug.mentalDamage = PlayerPrefs.GetInt("Mental");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ug = GameObject.Find("UI").GetComponent<UIGenerator>();
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
