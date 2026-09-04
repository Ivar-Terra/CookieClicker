using System.Threading;
using TMPro;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI CookieCount;
    [SerializeField] int Cookies;
    [SerializeField] Animator CanvesAnimator;

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
        
        if(timer >= 1)
        {
            timer = 0;
            Cookies += +1;
            CookieCount.text = Cookies.ToString();
        }
    }
    public void BuyGrandma()
    {

    }
}
