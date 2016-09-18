using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleHudElement : MonoBehaviour
{
    public Canvas hudCanvas;
    Text hudText;

    // Use this for initialization
    void Start()
    {
        hudCanvas.gameObject.SetActive(false);
        hudText = hudCanvas.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 headPos = Camera.main.transform.position;
        Vector3 headDir = Camera.main.transform.forward;

        RaycastHit hitInfo;
        if (Physics.Raycast(headPos, headDir, out hitInfo, 10))
        {
            InsuredObject hitObject = hitInfo.collider.GetComponent<InsuredObject>();
            if (hitObject != null)
            {
                hudCanvas.gameObject.SetActive(true);

                // generate the HUD-Text
                hudText.text = hitObject.Type.ToString()
                    + "\n" + hitObject.ValueInEuro + "€";
                if(hitObject.Damage != null)
                {
                    hudText.text += "\n" + hitObject.Damage.ToString();
                }
                else
                {
                    hudText.text += "\nunharmed";
                }
                hudCanvas.transform.position = hitInfo.point;
            }
            else
            {
                hudCanvas.gameObject.SetActive(false);
            }
        }
        else
        {
            hudCanvas.gameObject.SetActive(false);
        }
    }
}