﻿using GlucoMan.BusinessLayer;
using SharedData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GlucoMan
{
    internal partial class DL_FlatText : DataLayer
    {
        internal  override void DeleteDatabase()
        {
            throw new NotImplementedException();
        }
        internal  override long? SaveParameter(string FieldName, string FieldValue, int? Key = null)
        {
            throw new NotImplementedException();
        }
        internal  override string RestoreParameter(string FieldName, int? Key = null)
        {
            throw new NotImplementedException();
        }
        //internal override string? ToString()
        //{
        //    return base.ToString();
        //}
        #region Meals and Foods
        internal  override List<Meal> GetMeals(DateTime? initialTime, DateTime? finalTime)
        {
            throw new NotImplementedException();
        }
        internal  override void SaveMeals(List<Meal> List)
        {
            throw new NotImplementedException();
        }
        internal  override int? SaveOneMeal(Meal Meal)
        {
            throw new NotImplementedException();
        }
        internal  override List<FoodInMeal> GetFoodsInMeal(int? IdMeal)
        {
            throw new NotImplementedException();
        }
        internal  override int? SaveOneFoodInMeal(FoodInMeal FoodToSave)
        {
            throw new NotImplementedException();
        }
        internal  override void SaveFoodsInMeal(List<FoodInMeal> List)
        {
            throw new NotImplementedException();
        }
        internal override Meal GetOneMeal(int? IdMeal)
        {
            throw new NotImplementedException();
        }
        internal override void DeleteOneMeal(Meal meal)
        {
            throw new NotImplementedException();
        }
        internal override void DeleteOneFoodInMeal(FoodInMeal Food)
        {
            throw new NotImplementedException();
        }
        //internal override void SaveRatioChoInsulinParameters(BL_BolusCalculation Parameters)
        //{
        //    throw new NotImplementedException();
        //}
        //internal override void RestoreRatioChoInsulinParameters(BL_BolusCalculation Parameters)
        //{
        //    throw new NotImplementedException();
        //}
        internal override List<Food> SearchFood(string Name, string Description)
        {
            throw new NotImplementedException();
        }
        internal override void DeleteOneGlucoseMeasurement(GlucoseRecord gr)
        {
            throw new NotImplementedException();
        }
        internal override int? SaveOneAlarm(Alarm currentAlarm)
        {
            throw new NotImplementedException();
        }
        internal override List<Alarm> ReadAllAlarms()
        {
            throw new NotImplementedException();
        }
        internal override int? SaveOneFood(Food currentFood)
        {
            throw new NotImplementedException();
        }
        internal override void DeleteOneFood(Food food)
        {
            throw new NotImplementedException();
        }
        internal override Food GetOneFood(int? IdFood)
        {
            throw new NotImplementedException();
        }
        internal override List<Food> GetFoods()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
