using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Motherflame : MonoBehaviour
{
    public Image GamePanel;
    bool win = false;

    public TextMeshProUGUI EndText;
    private float delay = 0.05f;
    private string currentText = "";
    private string fullText;

    private void Start()
    {
        fullText = "When light is revealed, the shadows rise...";
        StartCoroutine(Typewriter());
        GamePanel.color = new Color(0, 0, 0, 1);
    }

    void Update()
    {
        if (win)
        {
            fullText = "The shadows are far away because the flame burns stronger.\n" +
            "Thank you for playing!";
            if (GamePanel.color.a < 1)
            {
                GamePanel.color += new Color(0, 0, 0, 0.01f);


                //Disable inputs
            }
        }

        else
        {
            if (GamePanel.color.a >= 0)
            {
                GamePanel.color -= new Color(0, 0, 0, 0.01f);

            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //WIN
            Debug.Log("WINJEE");
            win = true;
            StartCoroutine(Typewriter());

        }
    }

    IEnumerator Typewriter()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            EndText.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        yield return new WaitForSeconds(1);
        EndText.text = "";
    }
}
