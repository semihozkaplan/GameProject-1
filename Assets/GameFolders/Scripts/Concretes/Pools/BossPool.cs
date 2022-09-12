using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Abstracts.Pools;
using FlyingAlien.Controllers;

namespace FlyingAlien.Pools
{

    public class BossPool : GenericPool<BossController>
    {

        public static BossPool Instance { get; private set; }

        protected override void SingletonObject()
        {
            if (Instance == null)
            {

                Instance = this;
                DontDestroyOnLoad(this.gameObject);

            }

            else
            {

                Destroy(this.gameObject);

            }

        }
        public override void ResetAllObjects()
        {
            foreach (BossController child in GetComponentsInChildren<BossController>())
            {
                //activeSelf dediğimiz olay inspector içerisindeki tik işaretidir yani obje aktifmi veya değilmi onu belirtir. Aktif ise true döner
                if(!child.gameObject.activeSelf){

                    continue;

                }

                child.KillGameObject();

            }
        }
    }


}

