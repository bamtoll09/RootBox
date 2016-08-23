using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject box_left;
    public GameObject box_right;
    public GameObject stick_left;
    public GameObject stick_right;
    public GameObject particle_top;
    public GameObject particle_left;
    public GameObject particle_right;
    //public GameObject circleBoard;
    //public GameObject CMR;

    public Animator ani_box_left;
    public Animator ani_box_right;
    public Animator ani_stick_left;
    public Animator ani_stick_right;
    public Animator ani_circleBoard;
    public Animator ani_cmr;

    public CircleBoard circleBoard;
    //public CameraMagager cmr;
    public Text resultText;
    public Button nextBtn;

    public static GameManager instance;

    bool pressed = false;
    float time = 0.0f;

    // Use this for initialization
    void Start () {
        instance = this;
        circleBoard.enabled = false;
        //cmr.enabled = false;
        resultText.text = "";
        nextBtn.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (pressed)
        {
            if (time >= 4.0f)
            {
                resultText.text = "황승연 1일 이용권";
                nextBtn.enabled = true;
            }

            time += Time.deltaTime;
        }

	}

    public void openRootBox()
    {
        particle_top.SetActive(false);
        particle_left.SetActive(false);
        particle_right.SetActive(false);

        ani_box_left.SetBool("isClicked", true);
        ani_box_right.SetBool("isClicked", true);
        ani_stick_left.SetBool("isClicked", true);
        ani_stick_right.SetBool("isClicked", true);
        ani_circleBoard.SetBool("isClicked", true);
        ani_cmr.SetBool("isClicked", true);

        circleBoard.enabled = true;
        //cmr.enabled = true;

        pressed = true;
    }

    public void reset() // Next
    {

    }
}
