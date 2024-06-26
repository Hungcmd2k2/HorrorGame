using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_NoKey_4 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool locked;
    public Animator anim;
    public Canvas textdoorlock;
    public Canvas TextDoor;
    public static bool keyfound_4;
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
        if (keyfound_4)
        {
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



    }
    public void showText()
    {
        if (keyfound_4)
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
        else
        {
            textdoorlock.gameObject.SetActive(true);
        }

    }
}
