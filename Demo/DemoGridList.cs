using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bzk.tool {
    public class DemoGridList : GridList<string, Button> {

        public List<string> strs;

        public override List<string> listData() {
            return strs;
        }

        internal override void refleshTile(string d, Button e, int idx) {
            e.gameObject.SetActive(true);
            Text t = e.GetComponentInChildren<Text>();
            t.text = d + " " + idx;
        }

        internal override void setEmplty(Button row) {
            row.gameObject.SetActive(false);
        }
    }
}
