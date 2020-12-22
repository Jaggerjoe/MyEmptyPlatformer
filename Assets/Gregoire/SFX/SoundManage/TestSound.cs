//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TestSound : MonoBehaviour
//{
//    [SerializeField]
//    private SoundScriptable m_MySound = null;

//    [SerializeField]
//    private AudioSource m_Mysource = null;

//    // Start is called before the first frame update
//    void Start()
//    {
//        Play(m_MySound.name);
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    public void Play(string name)
//    {
//        if(!m_Mysource.isPlaying)
//        {
//            m_Mysource.clip = m_MySound.clip[Random.Range(0, m_MySound.clip.Length)];
//            m_Mysource.Play();
//        }
//        else
//        {
//            return;
//        }
       
//        Debug.Log("je susi al ");
//    }
//}
