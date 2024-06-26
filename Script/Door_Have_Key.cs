using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Have_Key : MonoBehaviour
{
    // Start is called before the first frame update
    public bool locked;
    public Animator anim;
    public Canvas TextDoor;
    public AudioSource door;



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
        if (locked == true)
        {
            door.Play();
            anim.SetTrigger("open");
            locked = false;
        }
        else
        {
            door.Play();
            anim.SetTrigger("close");
            locked = true;
        }

    }
    public void showText()
    {
        if (locked == true)
        {
            TextDoor.gameObject.SetActive(true);
        }
        else
        {
            TextDoor.gameObject.SetActive(true);

        }
    }
}
