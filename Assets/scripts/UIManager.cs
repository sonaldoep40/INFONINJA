using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text messageText;
    private bool isMessageActive = false;
    private float textTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMessageActive)
        {
            Color color = messageText.color;
            color.a += 2f * Time.deltaTime;
            messageText.color = color;
            if (color.a>=1)
            {
                isMessageActive = false;
                textTimer = 0;
            }
        }
        else if (!isMessageActive)
        {
            textTimer += Time.deltaTime;
            if (textTimer >= 2f)
            {
                Color color = messageText.color;
                color.a -= 2f * Time.deltaTime;
                messageText.color = color;
                if (color.a <= 0)
                {
                    messageText.text = "";
                }
            }
        }
        
    }
    public void setMessage(string message)
    {
        messageText.text = message;
        Color color = messageText.color;
        color.a = 0;
        messageText.color = color;
        isMessageActive = true;
    }
}
