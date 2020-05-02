﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    public GameObject ShopUI;

    public void OpenShop(){

        ShopUI.SetActive(true);
    }

    public void CloseShop(){
        ShopUI.SetActive(false);
    }

}