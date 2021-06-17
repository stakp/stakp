using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace движение_для_rigidbody
{
    public class CraftControl : MonoBehaviour
    {
        private RigidBody _rigidbody;
        private float Speed = 5f;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void FixedUpdate() {

            float SideForce = Input.GetAxis("Horizontal")*Speed;
            float ForwardForce = Input.GetAxis("Vertical") * Speed;
            _rigidbody.AddForce(SideForce,0f,ForwardForce);
        }
    }
}
