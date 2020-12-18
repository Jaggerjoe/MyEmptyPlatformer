using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControler : MonoBehaviour
{
    private Animator m_Anim = null;

    // Start is called before the first frame update
    void Start()
    {
        m_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerJump()
    {
        m_Anim.SetTrigger("Jump");
    }

    public void OnBoolTrueWalk()
    {
        m_Anim.SetBool("Walk", true);
    }
 
    public void OnBoolWalkFalse()
    {
        m_Anim.SetBool("Walk", false);

    }
}
