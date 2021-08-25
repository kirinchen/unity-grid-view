using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bzk.tool {
    public class GridLayoutWidthFit : MonoBehaviour {

        private GridLayoutGroup layout;
        public int xCellSize = 3;
        public RectTransform rect;

        void Awake() {
            rect = GetComponent<RectTransform>();
            layout = GetComponent<GridLayoutGroup>();
        }

        void Start() {


        }

        public void reflesh() {
            var oldCellSize = layout.cellSize;
            layout.cellSize = new Vector2(rect.rect.width / xCellSize, oldCellSize.y);
        }


    }
}
