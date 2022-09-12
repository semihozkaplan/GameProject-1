using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyingAlien.Abstracts
{

    public abstract class LifeTimeController : MonoBehaviour
    {

        [SerializeField] float limitTime = 5f;
        protected float _currentTime;

        private void Update()
        {

            _currentTime += Time.deltaTime;

            if (_currentTime > limitTime)
            {

                KillGameObject();

            }

        }

        public abstract void KillGameObject();

    }

}




