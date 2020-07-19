using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public Animator armanime;
    public InputField inputString;
    public Button act;
    public Text currentText;
    string myname;
    int i, j;
    string[] words = new string[] { "girl", "boy", "good", "he", "hi", "morning", "night", "you","college","in","study","my","name","thank","i","one","two","three",
                                    "three","four","five","six","seven","eight","nine","zero"};

    string[] ignore = new string[] {"is", "am", "the", "of", "a", "an", "are", "and","fuck","cunt","shit","dick","pussy","nigga","nigger","motherfucker","dipshit"};

    void Start()
    {
        currentText.text = "";
        armanime = GetComponent<Animator>();
        act.onClick.AddListener(Change);
    }

    IEnumerator wait()
    {

        myname = inputString.text;
        myname = myname.ToLower();
        string[] ssize = myname.Split(null);
        for (j = 0; j < ssize.Length; j++)
        {
            for (i = 0; i < ignore.Length; i++)
            {
                if (ssize[j] == ignore[i])
                {
                    break;
                }
            }
            if (i != ignore.Length)
            {
                continue;
            }
            if (j > 0)
            {
                yield return new WaitForSeconds(2.5f);
            }

            for (i = 0; i < words.Length; i++)
            {
                if (ssize[j] == words[i])
                {
                    currentText.text = words[i];
                    armanime.Play(words[i]);
                    break;
                }
            }

            if (i == words.Length)
            {
                char[] array = ssize[j].ToCharArray();
                currentText.text = ssize[j];
                for (i = 0; i < array.Length; i++)
                {
                    if (i > 0) yield return new WaitForSeconds(2.5f);

                    switch (array[i])
                    {
                        case 'a':
                            {
                                armanime.Play("a");
                                break;
                            }
                        case 'b':
                            {
                                armanime.Play("b");
                                break;
                            }
                        case 'c':
                            {
                                armanime.Play("c");
                                break;
                            }
                        case 'd':
                            {
                                armanime.Play("d");
                                break;
                            }
                        case 'e':
                            {
                                armanime.Play("e");
                                break;
                            }
                        case 'f':
                            {
                                armanime.Play("f");
                                break;
                            }
                        case 'g':
                            {
                                armanime.Play("g");
                                break;
                            }
                        case 'h':
                            {
                                armanime.Play("h");
                                break;
                            }
                        case 'i':
                            {
                                armanime.Play("i1");
                                break;
                            }
                        case 'j':
                            {
                                armanime.Play("j");
                                break;
                            }
                        case 'k':
                            {
                                armanime.Play("k");
                                break;
                            }
                        case 'l':
                            {
                                armanime.Play("l");
                                break;
                            }
                        case 'm':
                            {
                                armanime.Play("m");
                                break;
                            }
                        case 'n':
                            {
                                armanime.Play("n");
                                break;
                            }
                        case 'o':
                            {
                                armanime.Play("o");
                                break;
                            }
                        case 'p':
                            {
                                armanime.Play("p");
                                break;
                            }
                        case 'q':
                            {
                                armanime.Play("q");
                                break;
                            }
                        case 'r':
                            {
                                armanime.Play("r");
                                break;
                            }
                        case 's':
                            {
                                armanime.Play("s");
                                break;
                            }
                        case 't':
                            {
                                armanime.Play("t");
                                break;
                            }
                        case 'u':
                            {
                                armanime.Play("u");
                                break;
                            }
                        case 'v':
                            {
                                armanime.Play("v");
                                break;
                            }
                        case 'w':
                            {
                                armanime.Play("w");
                                break;
                            }
                        case 'x':
                            {
                                armanime.Play("x");
                                break;
                            }
                        case 'y':
                            {
                                armanime.Play("y");
                                break;
                            }
                        case 'z':
                            {
                                armanime.Play("z");
                                break;
                            }
                        case '0':
                            {
                                armanime.Play("zero");
                                break;
                            }
                        case '1':
                            {
                                armanime.Play("one");
                                break;
                            }
                        case '2':
                            {
                                armanime.Play("two");
                                break;
                            }
                        case '3':
                            {
                                armanime.Play("three");
                                break;
                            }
                        case '4':
                            {
                                armanime.Play("four");
                                break;
                            }
                        case '5':
                            {
                                armanime.Play("five");
                                break;
                            }
                        case '6':
                            {
                                armanime.Play("six");
                                break;
                            }
                        case '7':
                            {
                                armanime.Play("seven");
                                break;
                            }
                        case '8':
                            {
                                armanime.Play("eight");
                                break;
                            }
                        case '9':
                            {
                                armanime.Play("nine");
                                break;
                            }

                    }
                }




            }
        }

        yield return new WaitForSeconds(2.5f);
        currentText.text = "";
        inputString.text = "";

    }

    public void Change()
    {
        StartCoroutine(wait());
    }
}

