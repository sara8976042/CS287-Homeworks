﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonGo.Core;

namespace PokemonGoWinForm
{
    public partial class ItemsWindow : Form
    {
        public Potion[] Potions;
        public int SelectedPotionIndex;
        public Pokemon[] Pokemons;
        public int SelectePokemonIndex;

        public ItemsWindow()
        {
            InitializeComponent();
            Potions = new Potion[]
            {
                new Potion()
                {
                    Name="Potion",
                    Description="傷藥,可以回復HP20",
                    RestoringHP=20,
                    Count=28
                },
                new Potion()
                {
                    Name="Super Potion",
                    Description="傷藥,可以回復HP50",
                    RestoringHP=50,
                    Count=34
                },
                new Potion()
                {
                    Name="Hyper Potion",
                    Description="傷藥,可以回復HP200",
                    RestoringHP=200,
                    Count=44
                }

            };

            Pokemons = new Pokemon[] 
            {
                new Pokemon()
                {
                    Name="妙蛙種子",
                    HP=200,
                    CurrentHP=30
                },
                new Pokemon()
                {
                    Name="妙蛙草",
                    HP=250,
                    CurrentHP=230
                }
            };

            PotionLabel.Text = string.Format("{0},{1}, x{2}", Potions[0].Name, Potions[0].Description, Potions[0].Count);
            SuperPotionLabel.Text = string.Format("{0},{1}, x{2}", Potions[1].Name, Potions[1].Description, Potions[1].Count);
            HyperPotionLabel.Text = string.Format("{0},{1}, x{2}", Potions[2].Name, Potions[2].Description, Potions[2].Count);
            Pokemon1Label.Text = string.Format("{0}, HP{1}/{2}",Pokemons[0].Name, Pokemons[0].CurrentHP, Pokemons[0].HP);
            Pokemon2Label.Text = string.Format("{0}, HP{1}/{2}", Pokemons[1].Name, Pokemons[1].CurrentHP, Pokemons[1].HP);
        }

        private void PotionLabel_Click(object sender, EventArgs e)
        {
            SelectedPotionIndex = 0;
        }

        private void SuperPotionLabel_Click(object sender, EventArgs e)
        {
            SelectedPotionIndex = 1;
        }

        private void HyperPotionLabel_Click(object sender, EventArgs e)
        {
            SelectedPotionIndex = 2;
        }

        private void Pokemon1Label_Click(object sender, EventArgs e)
        {
            SelectePokemonIndex = 0;
        }

        private void Pokemon2Label_Click(object sender, EventArgs e)
        {
            SelectePokemonIndex = 1;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            Pokemons[SelectePokemonIndex].CurrentHP += Potions[SelectedPotionIndex].RestoringHP;
            Potions[SelectedPotionIndex].Count--;
            PotionLabel.Text = string.Format("{0},{1}, x{2}", Potions[0].Name, Potions[0].Description, Potions[0].Count);
            SuperPotionLabel.Text = string.Format("{0},{1}, x{2}", Potions[1].Name, Potions[1].Description, Potions[1].Count);
            HyperPotionLabel.Text = string.Format("{0},{1}, x{2}", Potions[2].Name, Potions[2].Description, Potions[2].Count);
            Pokemon1Label.Text = string.Format("{0}, HP{1}/{2}", Pokemons[0].Name, Pokemons[0].CurrentHP, Pokemons[0].HP);
            Pokemon2Label.Text = string.Format("{0}, HP{1}/{2}", Pokemons[1].Name, Pokemons[1].CurrentHP, Pokemons[1].HP);
        }


    }
}
