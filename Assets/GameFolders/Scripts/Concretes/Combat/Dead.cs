using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   
using FlyingAlien.Abstracts.Pools;              

namespace FlyingAlien.Combats
{

    public class Dead : MonoBehaviour
    {
        public bool isDead { get; private set; }
        public event Action OnDead;
        

        private void OnCollisionEnter2D(Collision2D other)
        {

            isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0f;


        }


    }


}

