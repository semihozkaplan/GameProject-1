using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyingAlien.Movements;
using FlyingAlien.Controllers;
using FlyingAlien.Combats;

//Baska bir script dosyasından bu script dosyasına ulasabilmek için dosya yolu verdik boylecek baska bir script dosaysı tarafından erişilebilecek.

namespace FlyingAlien.Controllers
{

    public class PlayerController : MonoBehaviour
    {

        //field private bir fielddir.
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _pcinput;
        LaunchProjectile _launchProjectile;
        AudioSource _audioSource;
        Dead _dead;
        
        bool _isLeftMouseClicked;  //Global degisken olduğu için snake case yazimi kullandik.
        bool _isRightMouseClicked;
        private void Awake()
        {

            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _audioSource = GetComponent<AudioSource>();
            _pcinput = GetComponent<PcInputController>();
            _dead = GetComponent<Dead>();


        }

        //Input Update işleri burada yapılır.
        //Fizik motoru bazen update kısmına yetişemeyebilir bu yüzden inputlar burada, fizik işlemleri ise fixedupdate kısmında yapılır.
        private void Update()
        {

            if(_dead.isDead){

                return;

            }

            //GetMouseButton ile GetMouseButtonDown arasındaki fark şudur GetMouseButton mouse'a tıkladığın anda basılı tuttuğun süre kadar çalışır.
            //GetMouseButtonDown ise bir kere tıkladığın an true ya döner.

            if (_pcinput.LeftMouseClickDown)
            {

                _isLeftMouseClicked = true;

            }

            if (_pcinput.RightMouseClickDown)
            {

                _isRightMouseClicked = true;

            }

        }

        //Fixed Update fizik motoruyla senkronize çalışır.Yani fizik işlemleriniz fixed update kısmında yapmak sağlıklı olanıdır.
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {

                _jump.JumpAction(_rigidbody2D);
                _audioSource.Play();
                _isLeftMouseClicked = false;

            }

            if (_isRightMouseClicked)
            {

                _launchProjectile.LaunchAction();
                _isRightMouseClicked = false;

            }

        }
    }



}

