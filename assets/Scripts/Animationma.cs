using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationma : MonoBehaviour
{
    //열거형 : 제시하는 타입 중에 하나
    public enum AnimaterState
    {
        Ak_1, Ak_2, Ak_3, Idle
    }
    public AnimaterState state = AnimaterState.Idle;

    public Animator animator;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (state == AnimaterState.Idle)
            {
                animator.SetTrigger("Ak_1");
                state = AnimaterState.Ak_1;
            }
            else if (state == AnimaterState.Ak_1)
            {
                animator.SetTrigger("Ak_2");
                state = AnimaterState.Ak_2;
            }
            else if(state == AnimaterState.Ak_2)
            {
                animator.SetTrigger("Ak_3");
                state = AnimaterState.Idle;
            }
        }
    }
}
