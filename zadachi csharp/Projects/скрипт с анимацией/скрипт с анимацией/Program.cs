using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace скрипт_с_анимацией
{
    public class BangAtPosition : MonoBehaviour
    {
        public Rigidbody TargetRigidbody;
        public float ForceValue = 100f;
        public ParticleSystem ParticleSystem;

        void Update()
        {
            if (Input.GetMouseButtonsDown(1))
            {
                TargetRigidbody.AddForcePosition(transform * ForceValue, transform.position);
                ParticleSystem.Play();
            }
            
        }
    
    }
}
