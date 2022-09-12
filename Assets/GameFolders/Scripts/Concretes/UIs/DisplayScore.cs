using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace FlyingAlien.UIs
{


    public class DisplayScore : MonoBehaviour
    {

        TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start() {
            GameManager.Instance.OnScoreChange += HandleOnScoreChange;
        }

        private void OnDisable() {
            GameManager.Instance.OnScoreChange -= HandleOnScoreChange;
        }

        private void HandleOnScoreChange(int score){

            _scoreText.text = $"Score: {score}";

        }
   
   
    }



}

