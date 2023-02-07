using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Class_1 classCreator;
    public GameObject gameObject2;

    void Start()
    {
        classCreator = gameObject2.AddComponent<Class_1>();
        Debug.Log(classCreator);
        gameObject2.GetComponent<Class_1>().className = "erdal";
        gameObject2.GetComponent<Class_1>().classNo = 8;
        gameObject2.GetComponent<Class_1>().Class_1GetInfo();
    }
}
