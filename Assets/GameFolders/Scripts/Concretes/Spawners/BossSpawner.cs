using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Controllers;
using FlyingAlien.Abstracts.Spawners;
using FlyingAlien.Abstracts.Pools;
using FlyingAlien.Pools;


namespace FlyingAlien.Spawners
{

    public class BossSpawner : BaseSpawner
    {
        //Pooling kullandım bu yüzden yorum satırı yaptım ihtiyacım yok.
        //[SerializeField] EnemyController bossEnemy;

        protected override void Spawn()
        {
            //Pooling kullandığım için bu satırı yorum yaptım.
            //Instantiate(bossEnemy, this.transform);

            EnemyController newEnemy = BossPool.Instance.Get();
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);
        }

    }



}


