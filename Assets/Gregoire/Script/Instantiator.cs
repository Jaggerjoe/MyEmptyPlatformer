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
    public void InstantiatePref(LandingInfos p_Info)
    {
        if(p_Info.fallingTime >=.5)
        {
            Instantiate(m_Prefab, p_Info.landingPosition - new Vector3(0,1,0), Quaternion.identity);
        }
    }
    public void InstantiatePref(HitInfos p_HitInfos)
    {
        Instantiate(m_Prefab, p_HitInfos.impact,Quaternion.identity);
    }

    public void InstantiatePref(ShootInfos p_InfoShoot)
    {
        GameObject l_Instantite = Instantiate(m_Prefab, p_InfoShoot.origin, Quaternion.LookRotation(p_InfoShoot.direction, Vector3.forward) /** Quaternion.AngleAxis(90, Vector3.down)*/);
        //l_Instantite.transform.right = p_InfoShoot.direction;
    }
    public void InstantiatePref(MovementInfos p_Info)
    {
        Instantiate(m_Prefab, p_Info.currentPosition - new Vector3(0, 1f, 0), Quaternion.identity);
    } 
    public void InstantiatePref(JumpInfos p_Info)
    {
        Instantiate(m_Prefab, p_Info.jumpOrigin - new Vector3(0,1,0), Quaternion.identity);
    }
    public void InstantiatePref(SpawnInfos p_Info)
    {
        Instantiate(m_Prefab,p_Info.spawnPosition - new Vector3(0,.5f,0),Quaternion.identity);
    }
}
