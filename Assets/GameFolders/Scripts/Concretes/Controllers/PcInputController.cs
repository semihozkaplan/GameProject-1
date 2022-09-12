using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyingAlien.Controllers
{

    public class PcInputController : MonoBehaviour
    {

        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0); //=> işareti return Input.GetMouseButtonDown(0) demektir.
        public bool RightMouseClickDown => Input.GetMouseButtonDown(1);

        
    }

}
