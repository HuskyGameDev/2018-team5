namespace VRTK.Examples {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEventHelper;

    public class ButtonCooking : MonoBehaviour {

        public FRecep foodRecept;

        // Use this for initialization
        void Start() {
            buttonEvents = GetComponent<VRTK_Button_UnityEvents>();
            if (buttonEvents == null) {
                buttonEvents = gameObject.AddComponent<VRTK_Button_UnityEvents>();
            }
            buttonEvents.OnPushed.AddListener(handlePush);
        }

        // Update is called once per frame
        void Update() {

        }

        private VRTK_Button_UnityEvents buttonEvents;

        private void handlePush(object sender, Control3DEventArgs e) {
            VRTK_Logger.Info("Pushed");

            foodRecept.Act();
        }
    }

}

