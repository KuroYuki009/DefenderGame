using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTool : MonoBehaviour
{
    //設定必須
    public GameObject buildingWindowOBJ;//建築ウィンドウ「BuildingWindow」。

    //
    public GameObject instObject;
    public GameObject previewObject;
    GameObject previewCursorObject = null;//

    [SerializeField]bool buildModeSW = true;

    //保管用
    Quaternion osQR;//新型。プレイヤーが設定した回転軸を保管する。
    Vector3 rayHitVC;

    void Start()
    {
        
    }

     
    void Update()
    {
        if(buildModeSW == true)
        {
            if (previewObject != null && instObject != null) Building();//プレビュー、インストオブジェクトが設定されている場合、建築機能を動作させる。
            if (Input.GetButtonDown("Fire2"))
            {
                WindowActive(true);//BuildingWindowを表示する。
                buildModeSW = false;
            }
        }
    }

    public void WindowActive(bool activeSW)//BuildingWindowの有効、無効を切り替える。
    {
        if(activeSW == false) buildingWindowOBJ.SetActive(false);
        else if(activeSW == true)
        {
            Cursor.lockState = CursorLockMode.Confined;//マウスカーソルをウィンドウ内であれば自由に動かせるようにする。
            Cursor.visible = true;//マウスカーソルを見えるようにする。
            buildingWindowOBJ.SetActive(true);
        }
    }

    public void PickEnd()
    {
        if(previewCursorObject != null) Destroy(previewCursorObject.gameObject);
        Cursor.lockState = CursorLockMode.Locked;//マウスカーソルを中央に固定する。
        Cursor.visible = false;//マウスカーソルを見えなくする。

        buildModeSW = true;

        previewCursorObject = Instantiate(previewObject, rayHitVC, Quaternion.identity);
        
    }

    void Building()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        int mask = LayerMask.GetMask(new string[] { "Ground" });

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (osQR == Quaternion.Euler(0, 90f, 0))
                osQR = Quaternion.Euler(0, 0f, 0);
            else
                osQR = Quaternion.Euler(0, 90f, 0);
        }

        if (Physics.Raycast(ray, out hit, mask))
        {
            rayHitVC = hit.point;
            if (hit.collider.tag == "WallSnapPoint")
            {

                ObjectSnap oS = hit.collider.gameObject.GetComponent<ObjectSnap>();
                Vector3 osTF = oS.snapPoint;
                //Quaternion osQR = oS.snapQuat;//旧式。当たったスナップコライダーの向きを保管する。

                previewCursorObject.transform.position = new Vector3(osTF.x, 0, osTF.z);
                previewCursorObject.transform.rotation = osQR;


                if (Input.GetMouseButtonDown(0))
                    Instantiate(instObject, new Vector3(osTF.x, 0, osTF.z), osQR);
            }
            else
            {
                previewCursorObject.transform.position = rayHitVC;

                if (Input.GetMouseButtonDown(0))
                    Instantiate(instObject, new Vector3(rayHitVC.x, rayHitVC.y, rayHitVC.z), Quaternion.identity);
            }



        }
    }
}
