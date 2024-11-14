using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ClickTreasure : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnClick()
    {
        int coinPerClick = GameManager.instance.coinPerClick;
        GameManager.instance.AddCoin(coinPerClick);
        animator.SetBool("isClick", true);
    }
}
