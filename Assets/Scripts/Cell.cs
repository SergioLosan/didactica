﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CellTypes { emphy, enemy, chest, exit ,blocked};

public class Cell {

    public Vector3 GlobalPosition;
    public int Cost;
    public CellTypes CellType;
    
    public Cell(CellTypes CellType, Vector3 GlobalPosition, int Cost)
    {
        this.CellType = CellType;
        this.GlobalPosition = GlobalPosition;
        this.Cost = Cost;
    }
}
