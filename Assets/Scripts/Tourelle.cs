using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    public LayerMask target;
    public float rayDistance;
    public Transform firePoint;
    
    void Start()
    {
        Gizmos.color = Color.red;
    }

    
    
   
    void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(firePoint.position, rayDistance, firePoint.forward, 0f, target);
        
        foreach (var hit in hits)
        {
            Debug.Log(hit.transform.gameObject.name);
        }
    }
    
    private void OnDrawGizmos()
    { 
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rayDistance);
    }
}
