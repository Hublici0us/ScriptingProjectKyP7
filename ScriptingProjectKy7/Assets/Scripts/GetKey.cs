using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text booldisplay1;
    public Text booldisplay2;
    public Text booldisplay3;

    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool up = Input.GetKeyUp(KeyCode.Space);
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);

        if(up)
        {
            graphic.sprite = upgfx;
        }
        else if(down)
        {
            graphic.sprite = downgfx;
        }
        else if(held)
        {
            graphic.sprite = heldgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        booldisplay1.text = " " + held;
        booldisplay2.text = " " + up;
        booldisplay3.text = " " + down;
    }
}
