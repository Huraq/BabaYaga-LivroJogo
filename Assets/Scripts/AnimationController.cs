using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    public GameObject book;
    public Text pressText;
    public Color textColor;
    private bool opened, colorA0;
    // Start is called before the first frame update
    void Start()
    {
        colorA0 = false;
        opened = false;
        book = GameObject.Find("Book");
        anim = book.GetComponent<Animator>();
        pressText = GameObject.Find("PressAnyKey").GetComponent<Text>();
        textColor = pressText.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (!opened && Input.anyKeyDown)
        {
            opened = true;
            anim.SetTrigger("open");
            Destroy(pressText);
        }
        if (pressText)
            TextBlink();
    }


    public void TextBlink()
    {
        if (textColor.a > 0f && !colorA0)
        {
            textColor.a -= Time.deltaTime;
            pressText.color = textColor;
            if (textColor.a <= 0)
                colorA0 = true;
        }
        else if (textColor.a <= 1.0f && colorA0)
        {
            textColor.a += Time.deltaTime;
            pressText.color = textColor;
            if (textColor.a >= 1)
                colorA0 = false;
        }
    }
}
