using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPass : MonoBehaviour
{
    public Canvas textdoor;
    public Animator animator;
    public GameObject keyPad;
    public Canvas keypad_canvans;
    public GameObject Player;
    public static bool keyok;
    private BoxCollider box;
    public Canvas pointer;
    public GameObject huongdan;
    public Canvas huongdanmokhoa;
    
    // Start is called before the first frame update
    void Start()
    {
       box = GetComponent<BoxCollider>();
        
    }
    private void FixedUpdate()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            keyPad.gameObject.SetActive(false);
            keypad_canvans.gameObject.SetActive(false);
            Player.gameObject.SetActive(true);
            huongdan.gameObject.SetActive(true);
            huongdanmokhoa.gameObject.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (keyok)
        {
            keyPad.gameObject.SetActive(false);
            keypad_canvans.gameObject.SetActive(false);
            Player.gameObject.SetActive(true);
            huongdan.gameObject.SetActive(true);
            huongdanmokhoa.gameObject.SetActive(false);
            OpenDoor();
        }
    }
    public void callscreen()
    {
        keyPad.gameObject.SetActive(true);
        keypad_canvans.gameObject.SetActive(true);
        Player.gameObject.SetActive(false);
        textdoor.gameObject.SetActive(false);
        pointer.gameObject.SetActive(false);
        huongdan.gameObject.SetActive(false);
        huongdanmokhoa.gameObject.SetActive(true);
    }
    public void showText()
    {
        textdoor.gameObject.SetActive(true);
    }
    public void OpenDoor()
    {
        animator.SetTrigger("Open");
        box.enabled = false;
        
    }
}
