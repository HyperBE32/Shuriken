﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Shuriken.ViewModels;

namespace Shuriken.Models
{
    public class CharacterMapping : INotifyPropertyChanged
    {
        private char character;
        public char Character
        {
            get => character;
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                    character = value;
            }
        }

        public Sprite Sprite { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public CharacterMapping(char c, Sprite spr)
        {
            Character = c;
            Sprite = spr;
        }

        public CharacterMapping()
        {
            Sprite = new Sprite();
        }
    }
}
