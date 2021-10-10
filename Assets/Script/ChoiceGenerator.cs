using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceGenerator : MonoBehaviour
{
    public GameObject ChoicePrefab1;
    public GameObject ChoicePrefab2;
    int count;
    
    void ShowChoice()
    {
        if (count == 10)
        {
            ChoicePrefab1.SetActive(true);
            ChoicePrefab2.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        this.ChoicePrefab1 = GameObject.Find("Choice1");
        this.ChoicePrefab2 = GameObject.Find("Choice2");
        ChoicePrefab1.SetActive (false);
        ChoicePrefab2.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
