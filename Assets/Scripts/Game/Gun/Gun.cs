using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{
    [SerializeField] public GunData gunData;
    [SerializeField] public Transform muzzle;

    float timeSinceLastShot;
 /*   public int NumberOfItems { get; private set; }

    public UnityEvent<Gun> OnItemCollected;

    public void itemCollected()
    {
        NumberOfItems++;
        OnItemCollected.Invoke(this);
    }
 */
    public void Start()
    {

        gunData.currentAmmo = 31;
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput += StartReload;
    }

    public void StartReload()
    {
        //if(!gunData.reloading)
        //{
            Reload();
        //}
    }

 /*   private IEnumerator Reload()
    {
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = 31;

        gunData.reloading = false;
    }
 */

    private void Reload()
    {
        gunData.reloading = true;

        gunData.currentAmmo = 31;

        gunData.reloading = false;
        Debug.Log("Reload complete");
    }


    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    private void Shoot()
    {
        //Debug.Log("before if");
        if(gunData.currentAmmo > 0)
        {
            
            //if (CanShoot())
            //{
                Debug.Log("before raycast");
                if (Physics.Raycast(muzzle.position, transform.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    Debug.Log(hitInfo.transform.name);
                    IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                    damageable?.TakeDamage(gunData.damage);
                }

                gunData.currentAmmo--;
                timeSinceLastShot = 0;
                OnGunShot();

                PlayerAmmo ammo = GetComponent<PlayerAmmo>();

                if (ammo != null)
                {
                    ammo.playerShot();
                }

                //if(gunData.currentAmmo < 0)

            //}
        }
    }



    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(muzzle.position, transform.forward, Color.yellow);

        PlayerAmmo ammo = GetComponent<PlayerAmmo>();
        if (/*gunData.currentAmmo < 0 && */Input.GetKeyDown(KeyCode.R))
        {
            ammo.playerReload();
            
        }

    }


    private void OnGunShot()
    {

    }
}
