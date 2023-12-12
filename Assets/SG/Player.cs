using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{
    public class Player : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.one;
            Debug.Log("변경사항");

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("공격");
            }
        }
    }

}
