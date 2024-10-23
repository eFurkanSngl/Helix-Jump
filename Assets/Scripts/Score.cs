using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _text;
   private int _score;

   private void Start()
   {
     
   }

   public void IncreaseScore(int score)
   {
      _score += score;
      if (_text != null)
      {
         _text.text = _score.ToString();
      }
   }
}
