using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsVis : MonoBehaviour
{
    public GameObject tipsKeyText;
    public GameObject textObj;
    public GameObject backImg;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            tipsKeyText.SetActive(false);
            textObj.SetActive(true);
            backImg.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.F1))
        {
            tipsKeyText.SetActive(true);
            textObj.SetActive(false);
            backImg.SetActive(false);
        }
    }
}
