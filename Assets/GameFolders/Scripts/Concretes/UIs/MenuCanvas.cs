using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyingAlien.UI
{

    public class MenuCanvas : MonoBehaviour
    {
        public void ExitButtonClicked()
        {

            GameManager.Instance.ExitGame();

        }

        public void StartButtonClicked()
        {

            GameManager.Instance.StartGame();

        }
    }


}

