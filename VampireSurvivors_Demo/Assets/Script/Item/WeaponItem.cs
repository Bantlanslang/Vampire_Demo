
using UnityEngine;

//fileName = 創建物件名稱 order = menuName排序
[CreateAssetMenu(menuName = "Item/weaponItem")]
public class WeaponItem : Item
{
    public GameObject modelPrefab;
    public float Damage;
    public float Level;
    public int bulletAmount;
    public float AttackArea;
    public float coldDownTime;
    public float FireSpeed;
    public float DestroyTime;
    public bool canDestroy;
    public bool isTrace;
}
