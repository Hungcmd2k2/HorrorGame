using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_NoKey : MonoBehaviour
{
    // Start is called before the first frame update
    public bool locked;
    public Animator anim;
    public Canvas textdoorlock;
    public Canvas TextDoor;
    public static bool keyfound;
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
       if (keyfound)
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
        if (keyfound)
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
