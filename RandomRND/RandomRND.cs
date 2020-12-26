using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Windows;
using Random = UnityEngine.Random;//you can switch "UnityEngine.Random" to "System.Random" (optional)

public class RandomRND : MonoBehaviour
{
    public GameObject GameObject1;//write instead of "GameObject1" the name of the GameObject you want
    public GameObject GameObject2;//write instead of "GameObject2" the name of the GameObject you want
    public int TXT = 225;//you can switch "225" to the maximuim Random Number
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Random rnd = new Random();
    int RND;
    public void RNDm()
    {
        int RND = UnityEngine.Random.Range(1, TXT);//you can switch "UnityEngine.Random" to "System.Random" (optional)
        Debug.Log(RND+"asdfghjkl");//Debug.Log is "for writing the message you want in the console" "" is "for writing custom message" + is "for merging 2 or more messages" (optional)
        if (RND == 1)//== is "is" || is "or" && is "and" > is "greater than" < is "less than" //is "for writing anything" ; is "for finishing the sentence that you wrote it" (you can write whatever you want instead of "== 1"(optinal))
        {
            //write what will it happen if RND(Random Number) is ...
            GameObject1.SetActive(true);//write instead of "GameObject1" the name of the GameObject you want, to turn it on using ".SetActive(true)" or off using ".SetActive(false)" (optional)
        }
        else if (RND == 2)//you can write whatever you want instead of "== 2" (write another thing)
        {
            //write what will it happen if RND(Random Number) is ...
            GameObject2.SetActive(true);//write instead of "GameObject2" the name of the GameObject you want, to turn it on using ".SetActive(true)" or off using ".SetActive(false)" (optional)
        }
        //if you want you can copy and paste else if again on this line(optional)
        else//others(optional)
        {
            //write what will it happen if RND(Random Number) is other than everything you wrote it up from if (23) until before else(this else isn't else if)
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//Don't forget to subscribe to:
//Code AGM0
//or https://www.youtube.com/channel/UCTlYFLC26D18vtkuvW60tfw //hold "Ctrl"(in the keyboard) and click at this link then click at "subscribe" button
//or http://bit.ly/codeagm //hold "Ctrl"(in the keyboard) and click at this link then click at "subscribe" button

