using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    CameraShakeControle m_JumpInfo = null; 
    [SerializeField]
    CameraShakeControle m_HitInfo = null;
    [SerializeField]
    CameraShakeControle m_HitTarget = null;
    public void StartCoroutine(HitInfos infos)
    {
        StartCoroutine(Shake(m_HitInfo.m_Duration, m_HitInfo.m_Magnitude));
    }
    public void HitTarget(HitInfos p_HitTarget)
    {
        StartCoroutine(Shake(m_HitTarget.m_Duration, m_HitTarget.m_Magnitude));

    }

    public void Jump(LandingInfos info)
    {
        if (info.fallingTime >= .5)
        {
            StartCoroutine(Shake(m_JumpInfo.m_Duration, m_JumpInfo.m_Magnitude));
            //m_Atterissage.Play();
        }
    }
   public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;

            transform.localPosition = originalPos;
        }
    }
}
