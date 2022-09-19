using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public PlayerState playerState;
    public GameObject enemyFx;
    public GameObject gemExp;

    [SerializeField]private int EnemyCount;
    [SerializeField]private int EnemyCountRange = 100;
    private float Timer = 0;

    private void Start()
    {
        
    }
    private void Update()
    {
        updateEnemySpawn();
    }
    void updateEnemySpawn(){
        
        Timer += Time.deltaTime;
        if (!playerState.isDead)
        {
            if(EnemyCount <= EnemyCountRange){
                if(Timer >= 3.0f){
                    Timer = 0;
                    //生成範圍
                    Vector2 spawnVector = new Vector2(Random.Range(playerState.transform.position.x-30,playerState.transform.position.x + 20)
                    ,Random.Range(playerState.transform.position.y-30,playerState.transform.position.y + 20));

                    GameObject spawnEnemy = Instantiate(enemyPrefab,spawnVector,Quaternion.identity);
                    spawnEnemy.GetComponent<EnemyState>().OnDeath += EnemyDeath;
                    EnemyCount ++;
                }
            }
        }
    }

    //敵人死亡掉落
    private void EnemyDeath()
    {
        EnemyState[] enemyState = FindObjectsOfType<EnemyState>();
        foreach (var enemy in enemyState)
        {
            if(enemy.isDead){
                GameObject EnemyFx = Instantiate(enemyFx,enemy.transform.position,Quaternion.identity);
                Destroy(EnemyFx,0.5f);
                GameObject GemExp = Instantiate(gemExp,enemy.transform.position,Quaternion.identity);
            }
        }
    }
}
