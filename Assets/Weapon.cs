using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 21;
    public float fireRate = 1;
    public float forseRate = 1;
    public float range = 15;
    public ParticleSystem muzzleFlash;
    public Transform bulletSpawn;
    public AudioClip shotSFX;
    public AudioSource audioSorce;
    public Camera cam;
    public Animator WeaponAnimator;

    private float nextFire = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }
    void Shoot()
    {
        WeaponAnimator.Play("Shoot");
        audioSorce.PlayOneShot(shotSFX);
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position,cam.transform.forward,out hit, range)) {
            if (hit.collider.GetComponent<Enemy>() != null)
            {
                Enemy hitEnemy = hit.collider.GetComponent<Enemy>();
                Debug.Log("Можно нанести урон ? " + hitEnemy.doDamage);
                if (hitEnemy.doDamage)
                {
                    hitEnemy.Damage(damage);
                }
            }
        }
    }
}
