using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public static int Va;
    public int ItemID;
    public Text PirceTxt;
    public Text QuantityTxt;
    //public Text RockTxt;
    public Text AdjasTxt;
    public Text ColoTxt;
    public Text RowTxt;
    ///public Text ColoumnTxt;
    public GameObject ShopManager;

    void Update()
    {
        /*int amone = PlayerPrefs.GetInt("amone");
        amone += 1;
        AmonTxt.text = "" + amone;
        PlayerPrefs.SetInt("amone", amone);
        ShopManager.GetComponent<ShopManagerScript>().Buy();*/
        
        //PirceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        int numberToRow = PlayerPrefs.GetInt("numRowshow");
                //int numberToSho = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID];// + "" + numberToShow;
        RowTxt.text = "" + numberToRow;
        //QuantityTxt.text = "" + numberToSho;// + numberToSho; //+ ammo;

        int numberToAdjas = PlayerPrefs.GetInt("numAdjasshow");
        AdjasTxt.text = "" + numberToAdjas;

        /*int numberToRock = PlayerPrefs.GetInt("numRockshow");
        RockTxt.text = "" + numberToRock;*///for future

        int numberToCol = PlayerPrefs.GetInt("numColshow");
        ColoTxt.text = "" + numberToCol;
        /*int numberToColmn = PlayerPrefs.GetInt("numColoumnshow");
        ColoumnTxt.text = "" + numberToColmn;*/
        //QuantityTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();// + numberToSho.ToString(); //quan;
        //PlayerPrefs.SetInt("numshow", numberToShow)
        //QuantityTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString() + "" + numberToShow; //+ ammo;
        //PlayerPrefs.SetInt("quant", ammo);
        //Qualityv.text = QuantityTxt.text; take it to another object
        /*PirceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        Va = PlayerPrefs.GetInt("quantity", Va);
        
        Qualityv.text = QuantityTxt.text;
        GetComponent<ShopManagerScript>().Buy();*/
    }
}
