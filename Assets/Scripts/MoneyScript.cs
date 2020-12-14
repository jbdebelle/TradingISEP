using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyScript : MonoBehaviour
{
    [SerializeField]
    private float account = 9000 ;
    [SerializeField]
    private float numShares = 40;
    [SerializeField]
    Text MoneyAccount;
    [SerializeField]
    Text NumberShares;
    [SerializeField]
    Text toogleAmount;
    
    private float StockPrice = Sample.sharePrice;
    // Start is called before the first frame update

    public void ToggleAmountFunction() 
    {


        toogleAmount.text = ""+GameObject.Find("SellandbuyAmount").GetComponent<Slider>().value; 

    }
    private void Awake()
    {
        StockPrice = Sample.sharePrice;
        MoneyAccount.text = "Money : " + account;
        NumberShares.text = "number of shares :" + numShares;
    }

    public void BuyStock()
    {
        StockPrice = Sample.sharePrice;
        float sellandbuyNumShares=GameObject.Find("SellandbuyAmount").GetComponent<Slider>().value;
        if (account-(sellandbuyNumShares * StockPrice)>=0) {
            account -= sellandbuyNumShares * StockPrice;
            numShares += sellandbuyNumShares;
            MoneyAccount.text = "Money : " + account;
            NumberShares.text = "number of shares :" + numShares;
        }
    }

    // Update is called once per frame
    public void SellStock()
    {
        StockPrice = Sample.sharePrice;
        float sellandbuyNumShares = GameObject.Find("SellandbuyAmount").GetComponent<Slider>().value;
        if (numShares-sellandbuyNumShares>=0)
        {
            account += sellandbuyNumShares * StockPrice;
            numShares -= sellandbuyNumShares;
            MoneyAccount.text = "Money :" + account;
            NumberShares.text = "number of shares :" + numShares;
        }
    }
}
