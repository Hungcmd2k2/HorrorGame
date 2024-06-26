using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Khoảng cách Raycast từ camera
    public float interactionDistance = 5f;

    // Layer chỉ định các đối tượng mà Raycast sẽ va chạm
    public LayerMask interactableLayer;
    public Camera cam;
    [Header("Text_Game")]
    public Canvas pointer;
    public Canvas TextDoor;
    public Canvas textdoorlock;
    public Canvas TextpickupFlash;
    public Canvas TextLamp;
    public GameObject Qrcode_1;
    public GameObject Hung_2;
    public GameObject Item_3;
    public GameObject Item_4;
  


    void Update()
    {
        // Tạo một Ray từ trung tâm của màn hình camera
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        // Tạo một RaycastHit để lưu thông tin về va chạm
        RaycastHit hit;

        // Kiểm tra xem Raycast có va chạm với đối tượng trong khoảng cách interactionDistance không
        if (Physics.Raycast(ray, out hit, interactionDistance, interactableLayer))
        {
            pointer.gameObject.SetActive(true);

            // Điểm bắt đầu của đường Raycast
            Vector3 startPoint = ray.origin;

            // Điểm kết thúc của đường Raycast (điểm va chạm)
            Vector3 endPoint = hit.point;

            // Vẽ đường Raycast
            Debug.DrawLine(startPoint, endPoint, Color.red);
            // Lấy đối tượng mà Raycast va chạm
            GameObject hitObject = hit.collider.gameObject;

            // Kiểm tra xem đối tượng có phản ứng tương tác không (có một script phản ứng tương tác)
            //Tương tác với cửa đang khóa 1
            Door_NoKey door_NoKey = hitObject.GetComponent<Door_NoKey>();
            if (door_NoKey != null)
            {
                HandeDoorNoKey(door_NoKey);
            }
            //Tương tác với cửa đang khóa 2
            Door_NoKey_2 door_NoKey_2 = hitObject.GetComponent<Door_NoKey_2>();
            if (door_NoKey_2 != null)
            {
                HandeDoorNoKey_2(door_NoKey_2);
            }
            //Tương tác với cửa đang khóa 3
            Door_NoKey_3 door_NoKey_3 = hitObject.GetComponent<Door_NoKey_3>();
            if (door_NoKey_3 != null)
            {
                HandeDoorNoKey_3(door_NoKey_3);
            }
            //Tương tác với cửa đang khóa 4
            Door_NoKey_4 door_NoKey_4 = hitObject.GetComponent<Door_NoKey_4>();
            if (door_NoKey_4 != null)
            {
                HandeDoorNoKey_4(door_NoKey_4);
            }
            // Tương tác vs cửa không  khóa
            Door_Have_Key door_Have_Key=hitObject.GetComponent<Door_Have_Key>();
            if (door_Have_Key != null)
            {
                HandleDoorHaveKey(door_Have_Key);
            }
            // Cửa end
            KeyPass keypass = hitObject.GetComponent<KeyPass>();
            if (keypass != null)
            {
                HandeKeyPass(keypass);
            }
            //Tương tác vs chìa khóa cửa 1
            PassKeyDoor_1 passKeyDoor_1 = hitObject.GetComponent<PassKeyDoor_1>();
            if (passKeyDoor_1 != null)
            {
                HandlePassKeyDoor_1(passKeyDoor_1);
            }
            //Tương tác vs chìa khóa cửa 2
            PassKeyDoor_2 passKeyDoor_2 = hitObject.GetComponent<PassKeyDoor_2>();
            if (passKeyDoor_2 != null)
            {
                HandlePassKeyDoor_2(passKeyDoor_2);
            }
            //Tương tác vs chìa khóa cửa 3
            PassKeyDoor_3 passKeyDoor_3 = hitObject.GetComponent<PassKeyDoor_3>();
            if (passKeyDoor_3 != null)
            {
                HandlePassKeyDoor_3(passKeyDoor_3);
            }
            //Tương tác vs chìa khóa cửa 4
            PassKeyDoor_4 passKeyDoor_4 = hitObject.GetComponent<PassKeyDoor_4>();
            if (passKeyDoor_4 != null)
            {
                HandlePassKeyDoor_4(passKeyDoor_4);
            }
            //Tương tác với flash
            Flashlight flashlight = hitObject.GetComponent<Flashlight>();
            if (flashlight != null)
            {
                HandleFlashLight(flashlight);
            }
            //Tương tác với Electric
           Electric electric = hitObject.GetComponent<Electric>();
            if (electric != null)
            {
                HandleElectric(electric);
            }
            //Tương tác với cac item................
            //item qr
            ShowItem item = hitObject.GetComponent<ShowItem>();
            if (item != null)
            {
                HandleItem(item);
            }
            //item hung
            ShowItem_hung showItem_Hung =hitObject.GetComponent<ShowItem_hung>();
            if (showItem_Hung != null)
            {
                HandleItem_Hung(showItem_Hung);
            }
            //item 3
            ShowItem_3 showItem_3 = hitObject.GetComponent<ShowItem_3>();
            if (showItem_3 != null)
            {
                HandleItem_3(showItem_3);
            }
            //item 4
            ShowItem_4 showItem_4 = hitObject.GetComponent<ShowItem_4>();
            if (showItem_4 != null)
            {
                HandleItem_4(showItem_4);
            }



        }
        else
        {
            /* Debug.DrawRay(ray.origin, ray.direction * interactionDistance, Color.green);*/
            OffAllText();
        }
    }
    void OffAllText()
    {
        pointer.gameObject.SetActive(false);
        TextDoor.gameObject.SetActive(false);
        textdoorlock.gameObject.SetActive(false);
        TextpickupFlash.gameObject.SetActive(false);
        TextLamp.gameObject.SetActive(false);
      
    }
    void HandeDoorNoKey(Door_NoKey door_NoKey)
    {
        door_NoKey.showText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            door_NoKey.DoorController();
        }
    }
    void HandeDoorNoKey_2(Door_NoKey_2 door_NoKey_2)
    {
        door_NoKey_2.showText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            door_NoKey_2.DoorController();
        }
    }
    void HandeDoorNoKey_3(Door_NoKey_3 door_NoKey_3)
    {
        door_NoKey_3.showText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            door_NoKey_3.DoorController();
        }
    }
    void HandeDoorNoKey_4(Door_NoKey_4 door_NoKey_4)
    {
        door_NoKey_4.showText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            door_NoKey_4.DoorController();
        }
    }
    void HandeKeyPass(KeyPass keypass)
    {
        keypass.showText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            keypass.callscreen();
        }
    }
    void  HandlePassKeyDoor_1(PassKeyDoor_1 passKeyDoor_1)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            passKeyDoor_1.KeyLock();
        }
        
    }
    void HandlePassKeyDoor_2(PassKeyDoor_2 passKeyDoor_2)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            passKeyDoor_2.KeyLock();
        }

    }
    void HandlePassKeyDoor_3(PassKeyDoor_3 passKeyDoor_3)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            passKeyDoor_3.KeyLock();
        }
    }
    void HandlePassKeyDoor_4(PassKeyDoor_4 passKeyDoor_4)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            passKeyDoor_4.KeyLock();
        }
    }
    void HandleDoorHaveKey(Door_Have_Key door_Have_Key)
    {
        door_Have_Key.showText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            door_Have_Key.DoorController();
        }
    }
    void HandleFlashLight(Flashlight flashlight)
    {
        flashlight.ShowText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.PickFlashlight();
        }
    }
    void HandleElectric(Electric electric)
    {
        electric.showText();
        if (Input.GetKeyDown(KeyCode.F))
        {
            electric.TurnLamp();
        }
    }
    void HandleItem(ShowItem item)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {   
            StartCoroutine(DelayedFunction_QR(0.5f));
            item.Showitem();
        }
    }
    IEnumerator DelayedFunction_QR(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Qrcode_1.gameObject.SetActive(false);

    }

    void HandleItem_Hung(ShowItem_hung showItem_Hung)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(DelayedFunction_Hung(0.5f));
            showItem_Hung.Showitem();
        }
    }
    IEnumerator DelayedFunction_Hung(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Hung_2.gameObject.SetActive(false);

    }
    void HandleItem_3(ShowItem_3 showItem_3)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(DelayedFunction_3(0.5f));
            showItem_3.Showitem();
        }
    }
    IEnumerator DelayedFunction_3(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Item_3.gameObject.SetActive(false);

    }
    void HandleItem_4(ShowItem_4 showItem_4)
    {
        TextpickupFlash.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(DelayedFunction_4(0.5f));
            showItem_4.Showitem();
        }
    }
    IEnumerator DelayedFunction_4(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Item_4.gameObject.SetActive(false);

    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Qrcode_1.gameObject.SetActive(true);
            Hung_2.gameObject.SetActive(true);
            Item_3.gameObject.SetActive(true);
            Item_4.gameObject.SetActive(true);
        }
    }
    
}
