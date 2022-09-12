using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyingAlien.Cores
{

    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] GameObject persistentPrefab;

        static bool _isFirstTime = true;

        private void Start()
        {
            if(_isFirstTime){

               SpawnPersistentObjects();
               _isFirstTime = false; 

            }
        }

        private void SpawnPersistentObjects()
        {
            //Bu işlem ile birlikte arkaplan müziği oyun kapanana kadar devam edecektir.
            GameObject newObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newObject);
        }
    
    
    }


}

