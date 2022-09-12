using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Combats;

namespace FlyingAlien.Abstracts.Pools
{

    public abstract class GenericPool<T> : MonoBehaviour where T : Component
    {
        //Oluşturulacak nesneleri burdan alıp kullanıcaz.
        [SerializeField] T[] prefabs;
        [SerializeField] int countLoop = 5;

        //Poolumuzu Queue şeklinde oluşturduk.
        Queue<T> _poolPrefabs = new Queue<T>();

        private void Awake()
        {
            SingletonObject();
        }

        private void OnEnable() {
            GameManager.Instance.OnSceneChange += ResetAllObjects;
        }

        private void OnDisable() {
            GameManager.Instance.OnSceneChange -= ResetAllObjects;
        }

        private void Start()
        {
            GrowPoolPrefab();
        }

        //Nesneyi tekilleştirmek için abstract method açtık.Böylece her bir nesne için farklı işlemler yapabiliriz(Abstract ve override)
        protected abstract void SingletonObject();

        //Nesneyi deaktif yap ve havuza at.
        public void Set(T poolObject)
        {

            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);

        }

        //Eğer pool içerisinde nesne yok ise poolu genişlet var ise o nesneye dön.
        public T Get()
        {

            if (_poolPrefabs.Count == 0)
            {

                GrowPoolPrefab();

            }

            return _poolPrefabs.Dequeue();

        }

        public abstract void ResetAllObjects();
       

        //Pool genişletme işlemi.
        //İstenilen miktar kadar nesne oluştur ve havuza at bizim burda istediğimiz miktar 5 çünkü yukarıdaki countLoop fieldini 5 girdik.
        private void GrowPoolPrefab()
        {

            for (int i = 0; i < countLoop; i++)
            {

                T newPrefab = Instantiate(prefabs[UnityEngine.Random.Range(0, prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);

            }
        }



    }


}


