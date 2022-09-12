using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Combats;

namespace FlyingAlien.UIs
{

    public class GameCanvas : MonoBehaviour
    {

        [SerializeField] GameObject gameOverPanel;

        private void Start() {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead(){

            gameOverPanel.SetActive(true);

        }

    }


}

