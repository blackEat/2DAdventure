using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineState : MonoBehaviour
{
    //��һ�����
    public int goldNeededToRoll = 0;
    public int rerollPenalty = 10;
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
