using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer m_Sprite = null;
    [SerializeField]
    private float m_FlaotMax = 1;
    private Color m_LerpColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //BeginInvincibility();
    }

    public void BeginInvincibility()
    {
        m_Sprite.color = Color.red;
    }
    public void UpdateInvincibility()
    {
        m_Sprite.color = Color.Lerp(m_Sprite.color, Color.white, 2 * Time.deltaTime);
        
    }

    public void EndInvincibility()
    {
        m_Sprite.color = Color.white;
    }
    
}
