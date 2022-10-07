using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTwo : MonoBehaviour
{
    int MyInt = 5

    void Start()
    {
        MyInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;

    }

}
