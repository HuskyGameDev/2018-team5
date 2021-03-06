﻿namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    public class ButtonReactor : MonoBehaviour
    {
        public float xMin, xMax, yMin, yMax, zMin, zMax;
        public GameObject go;
        public Transform dispenseLocation;

        private VRTK_Button_UnityEvents buttonEvents;

        private void Start()
        {
            buttonEvents = GetComponent<VRTK_Button_UnityEvents>();
            if (buttonEvents == null)
            {
                buttonEvents = gameObject.AddComponent<VRTK_Button_UnityEvents>();
            }
            buttonEvents.OnPushed.AddListener(handlePush);
        }

        private void handlePush(object sender, Control3DEventArgs e)
        {
            VRTK_Logger.Info("Pushed");

            GameObject newGo = (GameObject)Instantiate(go, dispenseLocation.position, Quaternion.identity);
            Rigidbody rb = newGo.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(Random.Range(xMin,xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax));
            //Destroy(newGo, 10f);
        }
    }
}