using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartUI : MonoBehaviour
{
    [SerializeField]
    private Health m_Player = null;
    [SerializeField]
    private int m_NumberOfHearth = 0;

    [SerializeField]
    private Image[] m_Heart = null;
    [SerializeField]
    private Sprite m_FullHeart = null;
    [SerializeField]
    private Sprite m_EmptyHeart = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteLifePlayer();
    }
    public void SpriteLifePlayer()
    {
        for (int i = 0; i < m_Heart.Length; i++)
        {
            if (i < m_Player.RemainingLives)
            {
                m_Heart[i].sprite = m_FullHeart;
            }
            else
            {
                m_Heart[i].sprite = m_EmptyHeart;
            }
            if (i < m_NumberOfHearth)
            {
                m_Heart[i].enabled = true;
            }
            else
            {
                m_Heart[i].enabled = false;
            }
        }
    }
}
