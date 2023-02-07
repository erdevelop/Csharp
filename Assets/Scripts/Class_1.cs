using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class_1 : MonoBehaviour
{
    public string className;
    public int classNo;

    public void Class_1GetInfo()
    {
        Debug.Log($"Class Name: {className} and Class No: {classNo} is started...");
    }
}
