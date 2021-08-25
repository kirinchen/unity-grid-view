using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bzk.tool {
    public class GridLayouSizeFit : MonoBehaviour {

        private GridLayoutGroup layout;
        public int xCount = 3;
        private RectTransform rect;

        void Awake() {
            rect = GetComponent<RectTransform>();
            layout = GetComponent<GridLayoutGroup>();
        }

        public void reflesh() {
            int count= transform.childCount;
            float cellWidth = rect.rect.width / xCount;
            float yc = (float)count / (float)xCount;
            int yCount = Mathf.CeilToInt(yc );
            float cellHeight = rect.rect.height / yCount;
            layout.cellSize = new Vector2(cellWidth, cellHeight);
        }


    }
}
