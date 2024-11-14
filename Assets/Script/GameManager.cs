using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int clickCount;
    public int coinPerClick = 2;
    public int coin = 0;

    [SerializeField] private TextMeshProUGUI clickCountText;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI coinPerClickText;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void AddCount(int click)
    {
        clickCount += click;
        clickCountText.text = clickCount.ToString();
    }

    public void AddCoin(int amount)
    {
        coin += amount;
        coinText.text = coin.ToString();
    }

    public void SetClickPerCoin(int newCoinPerClick)
    {
        coinPerClick = newCoinPerClick;
        coinPerClickText.text = coinPerClick.ToString();
    }
}
