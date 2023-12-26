using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingMenuWindow : MonoBehaviour
{
    float scrollFloat;

    public List<GameObject> pickWindow_Object;//選択可能枠を設定している。
    public List<Vector2> pickWindow_snapPoints = new List<Vector2>();//選択可能枠をスナップ配置する為の座標保管。

    //格納用
    RectTransform RTF;
    int objectCount = 0;

    int scanCount = 0;
    float verticalRow = 0;
    void Start()
    {
        objectCount = pickWindow_Object.Count;
        RTF = GetComponent<RectTransform>();
        scrollFloat = 210;

        AddSnapPoint();
    }

    
    void Update()
    {
        scrollFloat += 200.0f * Input.GetAxis("MouseScrollWheel");
        RTF.anchoredPosition = new Vector2(0, scrollFloat);

        if(objectCount < pickWindow_Object.Count)
        {
            pickWindow_Object[objectCount].GetComponent<RectTransform>().anchoredPosition = pickWindow_snapPoints[scanCount];
            scanCount += 1;
            
            objectCount += 1;
        }
        if (scanCount >= 5)
        {
            verticalRow += -210.0f;
            AddSnapPoint();
            scanCount = 0;
        }

    }

    void AddSnapPoint()
    {
        pickWindow_snapPoints.Clear();

        pickWindow_snapPoints.Add(new Vector2(-288, verticalRow));
        pickWindow_snapPoints.Add(new Vector2(-143, verticalRow));
        pickWindow_snapPoints.Add(new Vector2(2, verticalRow));
        pickWindow_snapPoints.Add(new Vector2(147, verticalRow));
        pickWindow_snapPoints.Add(new Vector2(292, verticalRow));
    }
}
