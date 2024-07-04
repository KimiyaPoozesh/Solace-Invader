using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject contButton;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index=0;
    public float typingSpeed;


    void Start()
    {
        zeroText();
        textDisplay.text=sentences[index];
        dialogue.SetActive(true);
    }

    void Update()
    {
        if(textDisplay.text == sentences[index]){
            contButton.SetActive(true);
        }
    }

    public void zeroText(){
        textDisplay.text = ""; 
        index = 0;
        dialogue.SetActive(false);
    }

    public void NextLine(){
        
        contButton.SetActive(false);
        if(index < sentences.Length-1){
            index++;
            textDisplay.text = "";
            StartCoroutine(Typing());
        }
        else{
           zeroText();
        }
    }

    IEnumerator Typing(){
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }


}
