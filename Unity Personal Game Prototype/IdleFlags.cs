using UnityEngine;
using System.Collections;

public class IdleFlags : StateMachineBehaviour
{
    public float m_Damping = 0.15f;


    private readonly int m_HashHorizontalPara = Animator.StringToHash("Horizontal");
    private readonly int m_HashVerticalPara = Animator.StringToHash("Vertical");


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(animator.GetBool("IdleFlag") == true)
        {
            
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }
    }
}
