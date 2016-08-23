using UnityEngine;
using System.Collections;

public class CameraMagager : MonoBehaviour {

    float speed = 60.0f;
    float time = 0.0f;
	
	// Update is called once per frame
	void Update () {
        if (time >= 1.2f && time < 1.95f)
        {
            if (transform.rotation.x > -45)
                transform.Rotate(new Vector3(-speed, 0.0f, 0.0f) * Time.deltaTime);
        }
        else if (speed == 45.0f)
        {
            speed = 30.0f;
        }
        else if (time >= 2.2f && time < 3.7f)
        {
            if (transform.rotation.x > 0.0f)
                transform.Rotate(new Vector3(speed, 0.0f, 0.0f) * Time.deltaTime);
        }
        else if (time >= 3.7f && transform.rotation.x != 0.0f)
            transform.rotation = Quaternion.Euler(Vector3.zero);

        time += Time.deltaTime;
	}

    void OnDisabled()
    {
        time = 0.0f;
        speed = 60.0f;
    }
}
