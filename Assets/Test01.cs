using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    int a, b;
    void Start()
    {
        a = 5;
        b = 2;
        Debug.Log($"start,{MathTwo(a,b)}");
    }

    int MathTwo(int num,int num2) 
    {
        int answer;
        return answer = num * num2;
    }

}
