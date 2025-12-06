// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.Lite.NUnit.Statics;

public static class Extensions
{
    public static TestCaseData ToTestCaseData<TTestData>(
        this TTestData testData,
        ArgsCode argsCode,
        string? testMethodName)
    where TTestData : notnull, ITestData
    {
        var convertedTestData = testData.ToParams(
            argsCode,
            PropsCode.Returns,
            out string testCaseName);
        var displayName = GetDisplayName(
            testMethodName,
            testCaseName);
        var testDataType = typeof(TTestData);
        var testCaseData = new TestCaseData(convertedTestData)
            .SetDescription(testCaseName)
            .SetName(displayName);
        var testDataReturns = testData as IReturns;
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
