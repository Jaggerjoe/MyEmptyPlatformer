 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMonster : MonoBehaviour
{
    private SpriteRenderer m_Sprite = null;
    private Animator m_Anim = null;
    // Start is called before the first frame update
    void Start()
    {
        m_Sprite = GetComponent<SpriteRenderer>();
        m_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dead(DeathInfos p_DInfos)
    {
        m_Sprite.color = Color.red;
        m_Anim.SetTrigger("Die");
    }

    public void Respaw()
    {
        m_Sprite.color = Color.white;
        m_Anim.SetTrigger("Walk");

    }

}
