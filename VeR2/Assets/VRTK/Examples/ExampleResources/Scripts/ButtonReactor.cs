namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    // modified VRTK code - spawns an object upon button press

    public class ButtonReactor : MonoBehaviour
    {
        public float xMin, xMax, yMin, yMax, zMin, zMax; // parameters for exit velocity
        public GameObject go; // reference to the object being spawned
        public Transform dispenseLocation; // reference to the location to spawn at

        private VRTK_Button_UnityEvents buttonEvents; // VRTK script to register the button press

        private void Start()
        {
            buttonEvents = GetComponent<VRTK_Button_UnityEvents>(); 
            if (buttonEvents == null) // instantiates buttonEvents if not already so
            {
                buttonEvents = gameObject.AddComponent<VRTK_Button_UnityEvents>();
            }
            buttonEvents.OnPushed.AddListener(handlePush); // when button is pressed, create object with handlePush
        }

        private void handlePush(object sender, Control3DEventArgs e) // create object at location with random velocity
        {
            VRTK_Logger.Info("Pushed"); // logs object spawn(?)

            GameObject newGo = (GameObject)Instantiate(go, dispenseLocation.position, Quaternion.identity); // creates new object
            Rigidbody rb = newGo.GetComponent<Rigidbody>(); // reference to rigidbody to manipulate velocity
            rb.velocity = new Vector3(Random.Range(xMin,xMax), Random.Range(yMin, yMax), Random.Range(zMin, zMax)); // random velocity within specified range
            //Destroy(newGo, 10f); // despawn object after certain amount of time
        }
    }
}