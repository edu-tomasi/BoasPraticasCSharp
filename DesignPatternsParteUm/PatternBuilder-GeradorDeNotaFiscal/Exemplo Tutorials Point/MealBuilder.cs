﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder_GeradorDeNotaFiscal
{
    public class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new VegBurguer());
            meal.addItem(new Coke());
            return meal;
        }

        public Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new ChickenBurguer());
            meal.addItem(new Pepsi());
            return meal;
        }
    }
}
