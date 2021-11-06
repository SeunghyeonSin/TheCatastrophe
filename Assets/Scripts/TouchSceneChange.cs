using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchSceneChange : MonoBehaviour
{
    public string scenename;

    public void SceneChange()
    {
        Debug.Log("SceneChange!!");
        SceneManager.LoadScene(scenename);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
