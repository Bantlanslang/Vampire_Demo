using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour, IBulletStyle
{   
    public WeaponItem weaponItem;
    Rigidbody2D rigid;

    private void Start() {
        
        
    }

    private void Update() {
        
        
    }
    private void OnTriggerStay2D(Collider2D other) {
        
        if(other.CompareTag("Enemy")){
            HitEnemy(other);
        }
    }

    //子彈發射方向
    public void BulletMode()
    {
        float angleStep = 360f/ weaponItem.bulletAmount;
        float angle = 0f;
        
        for(int i=0;i<=weaponItem.bulletAmount - 1;i++){

            Vector2 startPoint = PlayerManager.instance.transform.position;

            float DirectionX = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180);
            float DirectionY = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180);

            Vector2 BulletVector = new Vector2(DirectionX,DirectionY);
            Vector2 BulletMove = (BulletVector - startPoint).normalized * weaponItem.FireSpeed;

            GameObject obj = Instantiate(weaponItem.modelPrefab,startPoint,Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(BulletMove.x,BulletMove.y);
            if(weaponItem.canDestroy)
                Destroy(obj,weaponItem.DestroyTime);
            
            angle += angleStep;
        }
    }
    
    private void HitEnemy(Collider2D collider){

        IDamageable damageable = collider.GetComponent<IDamageable>();
        if(damageable != null){
            
            damageable.TakeDamage(weaponItem.Damage);
        }
        Destroy(this.gameObject);
    }


    //追蹤型
    // void trace(){
    //     if(PlayerManager.instance.currentTarget != null){

    //         Vector2 direction = PlayerManager.instance.currentTarget.transform.position - this.transform.position;
    //         rigid.velocity = direction * weaponItem.FireSpeed;

    //     }
    //     else{
    //         rigid.velocity = Vector2.up * weaponItem.FireSpeed;
    //     }
    // }
}
