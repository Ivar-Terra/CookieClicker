using System.Threading;
using TMPro;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI CookieCount;
    
    [SerializeField] int Cookies;
    [SerializeField] Animator CanvesAnimator;
    [SerializeField] int GrandmaCost;
    [SerializeField] int Grandmas;

    // int Cookies;

    float timer;

    public void ClickedCookie()
    {
        Cookies += + 1;
        CookieCount.text = Cookies.ToString();
        CanvesAnimator.SetTrigger("Click");
        
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (Grandmas >= 1)
        {
            if (timer >= 1)
            {
                timer = 0;
                Cookies += +Grandmas;
                CookieCount.text = Cookies.ToString();
            }
        }
       
    }
    public void BuyGrandma()
    {
        if(Cookies >= GrandmaCost)
        {
            Cookies -= GrandmaCost;
            CookieCount.text = Cookies.ToString();
            Grandmas += 1;
            
            GrandmaCost += 10;

        }
    }

}