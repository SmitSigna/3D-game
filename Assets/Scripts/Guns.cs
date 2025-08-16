using UnityEngine;
using UnityEngine.InputSystem;

public class Guns : MonoBehaviour
{
    
    [SerializeField] float damage = 10f;
    [SerializeField] float range = 100f;
    [SerializeField] Camera fpsCam;

    void Update()
    {
        if ( Input.GetMouseButton(0) )
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
           
        }


    }
}   
