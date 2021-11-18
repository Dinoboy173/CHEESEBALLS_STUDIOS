using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class ToggleCheeseText : MonoBehaviour
    {
        public Flowchart flowchart;

        public void ToggleCheddar()
        {
            flowchart.ExecuteBlock("Cheddar");
        }

        public void ToggleSwiss()
        {
            flowchart.ExecuteBlock("Swiss");
        }

        public void ToggleBlue()
        {
            flowchart.ExecuteBlock("Blue");
        }
    }
}
