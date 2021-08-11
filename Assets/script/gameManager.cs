using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class gameManager : MonoBehaviour
{
    public static int ScreenWidth = Screen.width;
    public static int ScreenHeight = Screen.height;
    objectPooling objectPooler;
    public RectTransform Panel;
    bool isOpen;
    public Image[] buttons;
    public Color red, purple;
    public Transform House;
    int buttonIndex;
    public Image timerBar;
    float timerSpawn;
    // Start is called before the first frame update
    void Start()
    {
        objectPooler = objectPooling.Instance;
        if(ScreenWidth==Screen.width||ScreenHeight==Screen.height)
        {
            ScreenHeight = Screen.width - (640 * 2);
            ScreenWidth = Screen.height - (360 * 2);
            Screen.SetResolution(ScreenWidth, ScreenHeight, true);
        }
        StartCoroutine("timerSpawnTank");
    }
    IEnumerator timerSpawnTank()
    {
        yield return new WaitForSeconds(1);
        timerSpawn +=1;
        timerBar.fillAmount = timerSpawn / 10;
              
        if (timerSpawn>=10)
        {
            spawanTank();
            timerSpawn = 0;
        }
        StartCoroutine("timerSpawnTank");
    }
    
    public void Tap()
    {
        timerSpawn += 0.5f;
        timerBar.fillAmount = timerSpawn / 10;

        if (timerSpawn >= 10)
        {
            spawanTank();
            timerSpawn = 0;
        }
    }
    void spawanTank()
    {
        objectPooler.SpawnFromPool("tank", House.transform.position, Quaternion.identity);
    }
    void OpenPanel()
    {
        Panel.DOKill();
        Panel.DOLocalMoveY(-367, 0.25f);
    }
    void ClosePanel()
    {
        Panel.DOKill();
        Panel.DOLocalMoveY(-910, 0.25f);
    }
    public void buttonPanel()
    {
        if(!isOpen)
        {
            isOpen = true;
            OpenPanel();
        }
        else
        {
            isOpen = false;
            ClosePanel();
        }
    }
   
    public void Home()
    {
        buttonIndex = 0;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttonIndex == i)
            {
                buttons[i].color = purple;
            }
            else
            {
                buttons[i].color = red;
            }
        }
    }
    public void Barrack()
    {
        buttonIndex = 1;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttonIndex == i)
            {
                buttons[i].color = purple;
            }
            else
            {
                buttons[i].color = red;
            }
        }
    }
    public void War()
    {
        buttonIndex = 2;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttonIndex == i)
            {
                buttons[i].color = purple;
            }
            else
            {
                buttons[i].color = red;
            }
        }
    }
    public void Shop()
    {
        buttonIndex = 3;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttonIndex == i)
            {
                buttons[i].color = purple;
            }
            else
            {
                buttons[i].color = red;
            }
        }
    }
    public void Option()
    {
        buttonIndex = 4;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttonIndex == i)
            {
                buttons[i].color = purple;
            }
            else
            {
                buttons[i].color = red;
            }
        }
    }
}
