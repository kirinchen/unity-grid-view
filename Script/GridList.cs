using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace bzk.tool {
    public abstract class GridList<D, E> : MonoBehaviour where E : Component {

        private E template;
        protected List<E> rows = new List<E>();
        public abstract List<D> listData();
        internal abstract void setEmplty(E row);
        internal abstract void refleshTile(D d, E e, int idx);
        public RectTransform parent;

        public virtual void Awake() {
            if (parent == null) {
                parent = GetComponent<RectTransform>();
            }
            template = GetComponentInChildren<E>();
            rows.Add(template);
        }

        public List<E> listRow() {
            return rows;
        }

        public virtual void reflesh() {
            initTile(template, 0);
            List<D> ds = listData();
            initTiles(ds);
            rows.ForEach(r => { setEmplty(r); });
            for (int i = 0; i < ds.Count; i++) {
                refleshTile(ds[i], rows[i], i);
            }
        }

        private void initTiles(List<D> ds) {
            while (ds.Count > rows.Count) {
                createTile();
            }
        }

        internal virtual void initTile(E e, int idx) { }

        private void createTile() {
            E nE = Instantiate(template, parent, false);
            rows.Add(nE);
            initTile(nE, rows.Count - 1);
        }
    }
}