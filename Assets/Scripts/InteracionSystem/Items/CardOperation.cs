﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType { ADD, SUBSTRACT, MULTIPLY, DIVIDE }

[CreateAssetMenu(fileName = "New CardOperation", menuName = "Inventory/CardOperation")]
public class CardOperation : Item { 
    
    public CardType cardOperation;
    public GameObject prefab;

    public string GetDescription(Card item)
    {
        return item.name;
    }
}
