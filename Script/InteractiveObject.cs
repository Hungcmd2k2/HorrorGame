using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    // Start is called before the first frame update
    public bool locked;
    public Animator anim;
    public Canvas TextDoor;
    


    void Start()
    {
        locked = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Hàm tương tác sẽ được gọi khi người chơi tương tác với đối tượng này
    public void DoorController()
    {
        Debug.Log("chạm vào tay nắm  cửa");
        if (locked==true)
        {
            anim.SetTrigger("open");
            locked = false;
        }
        else
        {
            anim.SetTrigger("close");
            locked = true;
        }

    }
    public void showText()
    {
         if(locked==true)
        {
            TextDoor.gameObject.SetActive(true);
        }
        else
        {
            TextDoor.gameObject.SetActive(true);

        }
    }
   
}

