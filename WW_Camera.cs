using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace WhiteWolf {

    public class WW_Camera : MonoBehaviour {

        public float PlusX(){

            Vector2 pos = Camera.main.ScreenToWorldPoint( new Vector2( Screen.width, Screen.height ) );
            return pos.x;

        }

        public float MinusX(){

            Vector2 pos = Camera.main.ScreenToWorldPoint( new Vector2( Screen.width, Screen.height ) );
            return -pos.x;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public float PlusY(){

            Vector2 pos = Camera.main.ScreenToWorldPoint( new Vector2( Screen.width, Screen.height ) );
            return pos.y;

        }

        public float MinusY(){

            Vector2 pos = Camera.main.ScreenToWorldPoint( new Vector2( Screen.width, Screen.height ) );
            return -pos.y;

        }

    }

}