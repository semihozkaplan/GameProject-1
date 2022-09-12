using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Abstracts.Pools;
using FlyingAlien.Pools;

namespace FlyingAlien.Controllers
{

    public class SnakeController : EnemyController
    {
        public override void SetEnemyPool()
        {
            SnakePool.Instance.Set(this);
        }
    }

}


