using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public GameObject imageObj;
    public Image cImage;
    public int pnum;

    public void NextImage()
    {
        switch (pnum)
        {
            case 1:
                cImage.sprite = Resources.Load("Image/image01", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 2:
                cImage.sprite = Resources.Load("Image/image02", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 3:
                cImage.sprite = Resources.Load("Image/image03", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 4:
                cImage.sprite = Resources.Load("Image/image04", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 5:
                cImage.sprite = Resources.Load("Image/image05", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 6:
                cImage.sprite = Resources.Load("Image/image06", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        imageObj = GameObject.Find("Image");
        cImage = imageObj.GetComponent<Image>();
        NextImage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
