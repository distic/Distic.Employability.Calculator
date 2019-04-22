using Distic.Employability.Calculator.Models;
using System.Collections.Generic;

namespace Distic.Employability.Calculator.Utilities
{
    /// <summary>
    /// Central Processing Unit for the main program.
    /// </summary>
    public class ECCPU
    {
        #region --- Properties ---

        public static TrainerViewModel gTrainerViewModel { get; set; }

        private bool gExpectOperator { get; set; }

        public enum ECValues
        {
            None,
            Poor,
            Public,
            Refugee,
            ForeignLanguage,
            Rich,
            Private,
            National,
            Arabic,
            Addition,
            Subtraction,
            Result
        }

        #endregion

        private List<ECValues> gUserInputList { get; set; }

        public ECCPU()
        {
            gUserInputList = new List<ECValues>();
            gExpectOperator = false;
        }

        internal void Reset()
        {
            gExpectOperator = false;
            gUserInputList.Clear();
        }

        private List<ECValues> GetFilteredUserInputList
        {
            get
            {
                var list = new List<ECValues>();

                foreach (var userInput in gUserInputList)
                {
                    if (userInput == ECValues.Addition || userInput == ECValues.Subtraction)
                    {
                        continue;
                    }

                    list.Add(userInput);
                }

                return list;
            }
        }

        private bool Compare(ref List<ECValues> list1, ref List<ECValues> list2)
        {
            var result = false;
            int findCount = 0;

            if (list1 == null)
                return result;

            if (list2 == null)
                return result;

            if (list1.Count != list2.Count)
                return result;

            foreach (var ecValueFromFile in list1)
            {
                var didFind = false;

                for (int i = 0; i < 4; i++)
                {
                    if (ecValueFromFile == list2[i])
                    {
                        didFind = true;
                        findCount++;
                        break;
                    }
                }

                if (!didFind)
                {
                    return result;
                }
            }

            if (findCount == 4)
            {
                result = true;
            }

            return result;
        }

        public string TryGetResult()
        {
            var result = string.Empty;

            var filteredUserInputList = GetFilteredUserInputList;

            foreach (var userInput in gTrainerViewModel.UserInputList)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    break;
                }

                var listFromFile = new List<ECValues>
                {
                    userInput.EcValue1,
                    userInput.EcValue2,
                    userInput.EcValue3,
                    userInput.EcValue4
                };

                if (Compare(ref listFromFile, ref filteredUserInputList))
                {
                    result = userInput.Result;
                }
            }

            return result;
        }

        public string ExtractCurrentOutput()
        {
            var screenBuffer = string.Empty;

            foreach (var ecValue in gUserInputList)
            {
                switch (ecValue)
                {
                    case ECValues.Addition:
                        screenBuffer += " +";
                        continue;

                    case ECValues.Subtraction:
                        screenBuffer += " -";
                        continue;
                }

                screenBuffer += " " + ecValue.ToString();
            }

            return screenBuffer;
        }

        private bool IsOperator(ECValues ecValue)
        {
            if (ecValue.Equals(ECValues.Addition))
            {
                return true;
            }

            if (ecValue.Equals(ECValues.Subtraction))
            {
                return true;
            }

            return false;
        }

        public void InsertEcValue(ECValues currEcValue)
        {
            if (gExpectOperator)
            {
                if (IsOperator(currEcValue))
                    goto Append;

                gUserInputList[gUserInputList.Count - 1] = currEcValue;
                return;
            }

            //
            // We're not expecting an operator. Carry on!
            //

            if (gUserInputList.Count == 0)
            {
                if (IsOperator(currEcValue))
                    return;

                goto Append;
            }

            if (IsOperator(currEcValue))
            {
                gUserInputList[gUserInputList.Count - 1] = currEcValue;
                return;
            }

        Append:
            gUserInputList.Add(currEcValue);
            gExpectOperator = !gExpectOperator;
        }
    }
}