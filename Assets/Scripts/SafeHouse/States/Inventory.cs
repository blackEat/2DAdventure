using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int Gold;
    public int Luck;

    public int BombCount;
    public int ArrowCount;

    public int BombCountMax;
    public int ArrowCountMax;

    private SlotMachineState slotMachine;
    private void Awake()
    {
        slotMachine = GetComponent<SlotMachineState>();
    }
}

public static class GlobalState
{
    private static GameObject mInstance;
    public static GameObject Instance
    {
        get
        {
            if (mInstance == null)
                mInstance = GameObject.FindGameObjectWithTag("GlobalState");
            return mInstance;
        }
    }

    public static Inventory Inventory => Instance.GetComponent<Inventory>();

    public static SlotMachineState SlotMachine => Instance.GetComponent<SlotMachineState>();

    public static Character PlayerCharacter => Instance.GetComponent<Character>();
}
