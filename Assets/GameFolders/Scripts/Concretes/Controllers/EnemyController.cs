using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Abstracts;
using FlyingAlien.Pools;

namespace FlyingAlien.Controllers
{

    public abstract class EnemyController : LifeTimeController
    {

        public override void KillGameObject()
        {

            _currentTime = 0f;
            SetEnemyPool();

        }

        public abstract void SetEnemyPool();

    }

}


