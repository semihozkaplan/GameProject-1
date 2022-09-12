using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Abstracts;
using FlyingAlien.Pools;

namespace FlyingAlien.Controllers
{
    public class ProjectileController : LifeTimeController
    {
       
        private void OnTriggerEnter2D(Collider2D collision)
        {
            BossController enemy = collision.GetComponent<BossController>();

            if(enemy != null){

                GameManager.Instance.IncreaseScore();
                enemy.KillGameObject();
                

            }

            KillGameObject();

        }
    
         public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }

        
    }

}


