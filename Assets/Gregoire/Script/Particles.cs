using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    [SerializeField]
    private GameObject m_ParticlesCoin = null;
    private SoundManager m_SoundManger = null;
    // Start is called before the first frame update
    void Start()
    {
        m_SoundManger = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(m_ParticlesCoin, transform.position, transform.rotation);
        //m_SoundManger.Play("Coin");
        Debug.Log("J'ai touché");
    }
}
