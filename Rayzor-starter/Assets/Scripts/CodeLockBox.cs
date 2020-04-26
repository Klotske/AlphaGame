using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeLockBox : MonoBehaviour
{
    public Text Button1Text;
    public Text Button2Text;
    public Text Button3Text;
    public Text Button4Text;
    public GameObject Door;
    public GameObject Button4;
    private bool big;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Button4.SetActive(big);
    }

    public void ItsBig(bool itsBig)
	{
        big = itsBig;
	}
    public void Button0Press()
	{
        int count1 = int.Parse(Button1Text.text);
        int count2 = int.Parse(Button2Text.text);
        int count3 = int.Parse(Button3Text.text);
        int count4 = int.Parse(Button4Text.text);
        if(big && (count1 == 2) && (count2 == 5) && (count3 == 8) && (count4 == 4))
		{
            
		}
        else if (!big && (count1 == 5) && (count2 == 2) && (count3 == 8))
		{
            Door.SetActive(false);
        }
    }

    public void Button1Press()
	{
        int count = int.Parse(Button1Text.text);
        count = count + 1;
        if (count>9)
		{
            count = 0;
		}
        Button1Text.text = count.ToString();
	}

    public void Button2Press()
    {
        int count = int.Parse(Button2Text.text);
        count = count + 1;
        if (count > 9)
        {
            count = 0;
        }
        Button2Text.text = count.ToString();
    }

    public void Button3Press()
    {
        int count = int.Parse(Button3Text.text);
        count = count + 1;
        if (count > 9)
        {
            count = 0;
        }
        Button3Text.text = count.ToString();
    }

    public void Button4Press()
    {
        int count = int.Parse(Button4Text.text);
        count = count + 1;
        if (count > 9)
        {
            count = 0;
        }
        Button4Text.text = count.ToString();
    }
}
