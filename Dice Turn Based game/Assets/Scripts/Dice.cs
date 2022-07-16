using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {
    private ArrayList arLst;
    void Start()
    {
        arLst = new ArrayList();
        arLst.Add(1);
        arLst.Add(2);
        arLst.Add(3);
        arLst.Add(4);
        arLst.Add(5);
        arLst.Add(6);
    }

    // Rolls the Dice
    public int roll(){
        int ranIndex = UnityEngine.Random.Range(1, arLst.Count);
        return (int) arLst[ranIndex];
    }

    // Adds Chances on the Dice
    public void addChances(int chance){
        arLst.Add(chance);
    }
}