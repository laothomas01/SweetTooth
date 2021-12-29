using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject followTarget;
    private Camera camera;
<<<<<<< HEAD
    public float yOffset=1f;
=======
    public float offsetX = 0, offsetY = 0, offsetZ = 0;
>>>>>>> ThomasLao
    private void Start()
    {
        //Cursor.visible = false;
    }
    void Awake()
    {
        // get the Camera component when the game runs
        // note if this script is not on the same GameObject as the Camera component, there will be an error
        camera = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        // get the X and Y position of the follow target and the Z position of the camera.
        // if the camera Z position is zero or position, the screen will be blank, so we are setting it to -10 (any negative number will work)
<<<<<<< HEAD
        Vector3 newPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y+yOffset, -10);
=======
        Vector3 newPosition = new Vector3(followTarget.transform.position.x + offsetX, followTarget.transform.position.y + offsetY, -10 + offsetZ);
>>>>>>> ThomasLao

        // set camera position to new position
        camera.transform.position = newPosition;
    }
}
