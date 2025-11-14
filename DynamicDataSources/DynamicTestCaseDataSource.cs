// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.Lite.NUnit.DynamicDataSources;

public abstract class DynamicTestCaseDataSource(ArgsCode argsCode)
: DynamicNamedDataSource<TestCaseData>(argsCode, PropsCode.Throws)
{
    #region Methods
    protected override TestCaseData TestDataToParams<TTestData>(
        TTestData testData,
        string? testMethodName)
    => testData.ToTestCaseData(
        ArgsCode,
        testMethodName);
    #endregion
}
