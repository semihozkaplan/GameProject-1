using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Abstracts.Pools;
using FlyingAlien.Pools;

namespace FlyingAlien.Controllers
{

    public class BossController : EnemyController
    {
        public override void SetEnemyPool()
        {
            BossPool.Instance.Set(this);
        }
    }

}


