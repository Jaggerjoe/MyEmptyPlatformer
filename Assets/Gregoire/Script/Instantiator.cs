using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Instantiator : ScriptableObject
{
    [SerializeField]
    private GameObject m_Prefab = null;

    public void InstantiatePref(CollectInfos p_Infos)
    {
        Instantiate(m_Prefab, p_Infos.position, Quaternion.identity);
    }
}
