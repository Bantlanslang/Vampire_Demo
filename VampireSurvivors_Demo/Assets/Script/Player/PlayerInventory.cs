using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public WeaponItem[] weaponItems;
    private PlayerState playerState;
    private float Timer;
    IBulletStyle bulletStyle;

    private void Awake() {
        playerState = GetComponent<PlayerState>();
    }
    private void Start() {

        StartCoroutine(AttackTimer());
    }
    private void Update() {

        
    }

    //also using Object pool
    public void SpawnWeapon(WeaponItem[] weaponItems){

        foreach (WeaponItem Item in weaponItems)
        {
            // GameObject weapon = Instantiate(Item.modelPrefab,this.transform.position,Quaternion.identity);  
            // if(Item.canDestroy)
            //     Destroy(weapon,Item.DestroyTime);
            // PlayerManager.instance.ColdDownTime = Item.coldDownTime;
            bulletStyle = Item.modelPrefab.GetComponent<IBulletStyle>();
        }
    }
    IEnumerator AttackTimer(){

        while(!playerState.isDead){

            SpawnWeapon(weaponItems);
            bulletStyle.BulletMode();
            yield return new WaitForSeconds(3.0f);
            
        }
    }
}
