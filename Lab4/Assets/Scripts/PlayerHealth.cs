using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    private int _score = 10;
    private Text _text;
    public static PlayerHealth Instance{get; private set;}
    private void Awake()
    {
        _text = GetComponent<Text>();
        Instance = this;
    }
    public void SubHealth(int value)
    {
        _score -= value;
        _text.text = _score.ToString();
    }
}
