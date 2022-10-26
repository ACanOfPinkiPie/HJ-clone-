﻿using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


namespace Assets.Scripts
{
    public class LevelNomberText : MonoBehaviour
    {
        public Text Text;
        public Game Game;

        private void Start()
        {
            Text.text = "Level" + (Game.LevelIndex + 1).ToString();
        }
    }
}