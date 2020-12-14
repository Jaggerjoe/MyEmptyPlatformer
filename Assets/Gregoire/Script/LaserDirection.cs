using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDirection : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= .2 && gameObject.activeSelf)
        {
            gameObject.SetActive(false);
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        //Gizmos.DrawRay(transform.position, m_Shoot.AimVector);
    }
}
