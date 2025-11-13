// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.Lite.NUnit.Statics;

public static class Extensions
{
    public static TestCaseData ToTestCaseData(
        this ITestData testData,
        ArgsCode argsCode,
        string? testMethodName = null)
    {
        var testDataToParams = TestDataToParams(
            testData,
            argsCode,
            PropsCode.Throws,
            out string testCaseName);
        var displayName = GetDisplayName(
            testMethodName,
            testCaseName);
        var testDataType = testData.GetType();
        var testCaseData = new TestCaseData(testDataToParams)
            .SetDescription(testCaseName)
            .SetName(displayName);
        var testDataReturns = testData as ITestDataReturns;
        bool isReturns = testDataReturns is not null;
        testCaseData.TypeArgs = argsCode switch
        {
            ArgsCode.Instance => [testDataType],
            ArgsCode.Properties => getGenericArgs(),
            _ => null,
        };

        return isReturns ?
            testCaseData.Returns(testDataReturns!.GetExpected())
            : testCaseData;

        #region Local methods
        Type[] getGenericArgs()
        {
            var genericArgs =
                testDataType.GetGenericArguments();

            return isReturns ?
                genericArgs[1..]
                : genericArgs;
        }
        #endregion
    }
}
