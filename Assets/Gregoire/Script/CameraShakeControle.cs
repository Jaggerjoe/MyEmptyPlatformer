using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Value",menuName ="ShakeCam")]
public class CameraShakeControle : ScriptableObject
{
    public float m_Duration;
    public float m_Magnitude;
}
