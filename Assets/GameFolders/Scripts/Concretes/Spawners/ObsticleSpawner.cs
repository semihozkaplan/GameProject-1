using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Controllers;
using System;
using FlyingAlien.Abstracts.Spawners;
using FlyingAlien.Abstracts.Pools;
using FlyingAlien.Pools;


namespace FlyingAlien.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {
        //Pooling işlemi için bu kısmı yorum satırına aldım.

        //Objeyi array haline getirdik.
        //SerializeField yapmamaızın nedeni objeyi inspector üzerinden sürükleyip bırakmak içindir.
        //[SerializeField] EnemyController[] enemies;

        protected override void Spawn()
        {
            //Aşağıdaki işlemleri yorum satırına aldım çünkü sürekli nesneyi oluşturmak yerine POOLING sistemine geçiş yaptım.

            //Range methodu 0'ıda kapsar ama alt sınırı gidemez. Ayrıca 4 e çıkamaz.
            //int enemyCount = UnityEngine.Random.Range(0, enemies.Length);
            //Instantiate(enemies[enemyCount], this.transform);

            EnemyController poolEnemy = SnakePool.Instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);

        }

    }

}





