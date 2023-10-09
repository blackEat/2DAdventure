using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class SlotMachineState : MonoBehaviour
{
    //��һ�����
    public int goldNeededToRoll = 0;
    public int rerollPenalty = 10;

    public Inventory inventory;
    private void Awake()
    {
        inventory = GetComponent<Inventory>();
    }
    public void TryRollSlotMachine()
    {
        GetRandomResult();
        
        ApplyRerollPenalty();
    }

    private void GetRandomResult()
    {
        
    }

    private void ApplyRerollPenalty()
    {
        goldNeededToRoll += rerollPenalty;
    }
}
