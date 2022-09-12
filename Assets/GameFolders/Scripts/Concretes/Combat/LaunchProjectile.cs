using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Controllers;
using FlyingAlien.Pools;

    //Ateşi player atacağı için compenantı player gameobjecte verdim.

namespace FlyingAlien.Combats
{

    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] float delayProjectile = 1f;


        float _currentDelayTime;
        bool _canLaunch;

        private void Update() {
           
            _currentDelayTime += Time.deltaTime;

            if(_currentDelayTime > delayProjectile){

                _canLaunch = true;
                _currentDelayTime = 0;

            }
        }

        public void LaunchAction(){

            if(_canLaunch){

                Instantiate(projectilePrefab, projectileTransform.transform.position, projectileTransform.transform.rotation);
                _canLaunch = false;

            }

        }


    } 


}

