﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FactoryProducer FP = new FactoryProducer();
            
            MealFactory myMealFactory;
            
            myMealFactory = FP.getMealFactory("WokFactory");

            Meal myMeal = myMealFactory.createMeal("Bangkok");

            myMeal.deliver();



        }
    }
}
