using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGenerator : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject mentalPrefab1;
    public GameObject mentalPrefab2;
    public GameObject mentalPrefab3;
    public GameObject heartPrefab1;
    public GameObject heartPrefab2;
    public GameObject heartPrefab3;
    public int heartDamage;
    public int mentalDamage;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(uiObject);
        this.mentalPrefab1 = GameObject.Find("Mental1");
        this.mentalPrefab2 = GameObject.Find("Mental2");
        this.mentalPrefab3 = GameObject.Find("Mental3");
        this.heartPrefab1 = GameObject.Find("Heart1");
        this.heartPrefab2 = GameObject.Find("Heart2");
        this.heartPrefab3 = GameObject.Find("Heart3");
    }

    public void DisappearMental()
    {
        switch (mentalDamage)
        {
            case 1:
                Destroy(mentalPrefab1);
                //Debug.Log("¸àÅ» °¨¼Ò");
                break;
            case 2:
                Destroy(mentalPrefab1);
                Destroy(mentalPrefab2);
                //Debug.Log("¸àÅ» °¨¼Ò");
                break;
            case 3:
                Destroy(mentalPrefab1);
                Destroy(mentalPrefab2);
                Destroy(mentalPrefab3);
                //Debug.Log("¸àÅ» °¨¼Ò");
                break;
        }
        if(mentalDamage == 3)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOver");
        }
    }

    public void DisappearHeart()
    {
        switch (heartDamage)
        {
            case 1:
                Destroy(heartPrefab1);
                //Debug.Log("Ã¼·Â °¨¼Ò");
                break;
            case 2:
                Destroy(heartPrefab1);
                Destroy(heartPrefab2);
                //Debug.Log("Ã¼·Â °¨¼Ò");
                break;
            case 3:
                Destroy(heartPrefab1);
                Destroy(heartPrefab2);
                Destroy(heartPrefab3);
                //Debug.Log("Ã¼·Â °¨¼Ò");
                break;
        }
        if(heartDamage == 3)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        DisappearHeart();
        DisappearMental();
    }
}
