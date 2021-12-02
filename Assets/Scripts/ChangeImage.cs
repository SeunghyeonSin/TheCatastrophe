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
            case 7:
                cImage.sprite = Resources.Load("Image/image07", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 8:
                cImage.sprite = Resources.Load("Image/image08", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 9:
                cImage.sprite = Resources.Load("Image/image09", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 10:
                cImage.sprite = Resources.Load("Image/image10", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 11:
                cImage.sprite = Resources.Load("Image/image11", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 12:
                cImage.sprite = Resources.Load("Image/image12", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 13:
                cImage.sprite = Resources.Load("Image/image13", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 14:
                cImage.sprite = Resources.Load("Image/image14", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 15:
                cImage.sprite = Resources.Load("Image/image15", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 16:
                cImage.sprite = Resources.Load("Image/image16", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 17:
                cImage.sprite = Resources.Load("Image/image17", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 18:
                cImage.sprite = Resources.Load("Image/image18", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 19:
                cImage.sprite = Resources.Load("Image/image19", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 20:
                cImage.sprite = Resources.Load("Image/image20", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 21:
                cImage.sprite = Resources.Load("Image/image21", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 22:
                cImage.sprite = Resources.Load("Image/image22", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 23:
                cImage.sprite = Resources.Load("Image/image23", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 24:
                cImage.sprite = Resources.Load("Image/image24", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 25:
                cImage.sprite = Resources.Load("Image/image25", typeof(Sprite)) as Sprite;
                Debug.Log("이미지 변경");
                break;
            case 26:
                cImage.sprite = Resources.Load("Image/image26", typeof(Sprite)) as Sprite;
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
