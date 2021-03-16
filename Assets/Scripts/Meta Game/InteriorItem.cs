using System;
using UnityEngine;
using UnityEngine.UI;

namespace Meta_Game {
    public class InteriorItem : MonoBehaviour {
        public GameObject priceText;
        
        public Button button;
        
        public int category;
        
        [HideInInspector]
        public bool bought;
        [HideInInspector]
        public new string name;

        private void Start() {
            name = gameObject.name;
        }
    }
}