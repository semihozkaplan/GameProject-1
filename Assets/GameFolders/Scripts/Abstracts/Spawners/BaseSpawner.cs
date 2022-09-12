using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Controllers;

namespace FlyingAlien.Abstracts.Spawners
{

    public abstract class BaseSpawner : MonoBehaviour
    {
        //Range attribute, atadığımız fieldların değer aralığını inspector üzerinden daha kolay düzenlememizi sağlar ve kısıtlar.
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;

        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 1f;


        float _currentSpawnTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTime();
        }

        private void Update()
        {

            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                
                Spawn();
                ResetTime();

            }

        }

        private void ResetTime()
        {

            _currentSpawnTime = 0f;
            _timeBoundary = UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
            //UnityEngine içerisindeki Random methodu ile System kütüphanesi içerisindeki Random methodu farklı bu nedenle başına UnityEngine. yazdık.

        }

        protected abstract void Spawn();

    }


}

