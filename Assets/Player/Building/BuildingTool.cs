using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTool : MonoBehaviour
{
    //�ݒ�K�{
    public GameObject buildingWindowOBJ;//���z�E�B���h�E�uBuildingWindow�v�B

    //
    public GameObject instObject;
    public GameObject previewObject;
    GameObject previewCursorObject = null;//

    [SerializeField]bool buildModeSW = true;

    //�ۊǗp
    Quaternion osQR;//�V�^�B�v���C���[���ݒ肵����]����ۊǂ���B
    Vector3 rayHitVC;

    void Start()
    {
        
    }

     
    void Update()
    {
        if(buildModeSW == true)
        {
            if (previewObject != null && instObject != null) Building();//�v���r���[�A�C���X�g�I�u�W�F�N�g���ݒ肳��Ă���ꍇ�A���z�@�\�𓮍삳����B
            if (Input.GetButtonDown("Fire2"))
            {
                WindowActive(true);//BuildingWindow��\������B
                buildModeSW = false;
            }
        }
    }

    public void WindowActive(bool activeSW)//BuildingWindow�̗L���A������؂�ւ���B
    {
        if(activeSW == false) buildingWindowOBJ.SetActive(false);
        else if(activeSW == true)
        {
            Cursor.lockState = CursorLockMode.Confined;//�}�E�X�J�[�\�����E�B���h�E���ł���Ύ��R�ɓ�������悤�ɂ���B
            Cursor.visible = true;//�}�E�X�J�[�\����������悤�ɂ���B
            buildingWindowOBJ.SetActive(true);
        }
    }

    public void PickEnd()
    {
        if(previewCursorObject != null) Destroy(previewCursorObject.gameObject);
        Cursor.lockState = CursorLockMode.Locked;//�}�E�X�J�[�\���𒆉��ɌŒ肷��B
        Cursor.visible = false;//�}�E�X�J�[�\���������Ȃ�����B

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
                //Quaternion osQR = oS.snapQuat;//�����B���������X�i�b�v�R���C�_�[�̌�����ۊǂ���B

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
