using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FlyingAlien.UIs
{

    public class GameOverPanel : MonoBehaviour
    {
        public void PlayAgainClicked()
        {

            GameManager.Instance.StartGame();
            

        }

        public void MenuClicked()
        {

            GameManager.Instance.StartMenuAsync();

        }
    }

}


