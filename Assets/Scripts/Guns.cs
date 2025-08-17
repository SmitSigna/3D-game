using UnityEngine;
using UnityEngine.InputSystem;

public class Guns : MonoBehaviour
{
    
    [SerializeField] float damage = 10f;
    [SerializeField] float range = 100f;
    [SerializeField] float fireRate = 30f;
    [SerializeField] Camera fpsCam;
    private float nextTimeToFire = 0f;

    void Update()
    {
        if ( Input.GetMouseButton(0) && Time.time >= nextTimeToFire )
        {
            nextTimeToFire = Time.time + (1f / fireRate);
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
           // Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
           
        }


    }
}   
