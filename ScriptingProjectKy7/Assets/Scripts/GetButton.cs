using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetButton : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool up = Input.GetButtonUp("Jump");
        bool held = Input.GetButton("Jump");

        if (down)
        {
            graphic.sprite = downgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + up;
        boolDisplay3.text = " " + held;
    }
}
