// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.Lite.NUnit.DynamicDataSources;

public abstract class DynamicTestCaseDataSource(ArgsCode argsCode)
: DynamicDataSource(argsCode, PropsCode.Throws)
{
    #region Methods
    private TestCaseData TestDataToTestCaseData(string? testMethodName, ITestData testData)
    => testData.ToTestCaseData(ArgsCode, testMethodName);

    #region TestDataToTestCaseData
    /// <summary>
    /// Creates a <see cref="TestCaseData"/> for a standard test case with one argument.
    /// </summary>
    /// <typeparam name="T1">Type of the first test argument.</typeparam>
    /// <param name="testMethodName">Name of the test method.</typeparam>
    /// <param name="definition">Description of the test scenario.</param>
    /// <param name="expected">Description of the expected result.</param>
    /// <param name="arg1">First argument value.</param>
    /// <returns>
    /// Array of test parameters formatted according to the current strategy.
    /// </returns>
    protected TestCaseData TestDataToTestCaseData<T1>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1));

    /// <summary>
    /// Creates a <see cref="TestCaseData"/> for a standard test case with two arguments.
    /// </summary>
    /// <typeparam name="T2">Type of the second test argument.</typeparam>
    /// <param name="arg2">The second argument.</param>
    /// <inheritdoc cref="TestDataToTestCaseData{T1}"/>
    protected TestCaseData TestDataToTestCaseData<T1, T2>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2));

    /// <inheritdoc cref="TestDataToTestCaseData{T1, T2}" />
    /// <typeparam name="T3">The type of the third argument.</typeparam>
    /// <param name="arg3">The third argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataToTestCaseData<T1, T2, T3>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2, T3? arg3)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2, arg3));

    /// <inheritdoc cref="TestDataToTestCaseData{T1, T2, T3}" />
    /// <typeparam name="T4">The type of the fourth argument.</typeparam>
    /// <param name="arg4">The fourth argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataToTestCaseData<T1, T2, T3, T4>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2, arg3, arg4));

    /// <inheritdoc cref="TestDataToTestCaseData{T1, T2, T3, T4}" />
    /// <typeparam name="T5">The type of the fifth argument.</typeparam>
    /// <param name="arg5">The fifth argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataToTestCaseData<T1, T2, T3, T4, T5>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5));

    /// <inheritdoc cref="TestDataToTestCaseData{T1, T2, T3, T4, T5}" />
    /// <typeparam name="T6">The type of the sixth argument.</typeparam>
    /// <param name="arg6">The sixth argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataToTestCaseData<T1, T2, T3, T4, T5, T6>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6));

    /// <inheritdoc cref="TestDataToTestCaseData{T1, T2, T3, T4, T5, T6}" />
    /// <typeparam name="T7">The type of the seventh argument.</typeparam>
    /// <param name="arg7">The seventh argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataToTestCaseData<T1, T2, T3, T4, T5, T6, T7>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7));

    /// <inheritdoc cref="TestDataToTestCaseData{T1, T2, T3, T4, T5, T6, T7}" />
    /// <typeparam name="T8">The type of the eighth argument.</typeparam>
    /// <param name="arg8">The eighth argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataToTestCaseData<T1, T2, T3, T4, T5, T6, T7, T8>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7, T8? arg8)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

    /// <inheritdoc cref="TestDataToTestCaseData{T1, T2, T3, T4, T5, T6, T7, T8}" />
    /// <typeparam name="T9">The type of the ninth argument.</typeparam>
    /// <param name="arg9">The ninth argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataToTestCaseData<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        string? testMethodName,
        string definition,
        string expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7, T8? arg8, T9? arg9)
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestData(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
    #endregion

    #region TestDataReturnsToTestCaseData
    /// <summary>
    /// Creates a <see cref="TestCaseData"/> for a test case expecting a value type return.
    /// </summary>
    /// <typeparam name="TStruct">Type of expected return value (non-nullable struct).</typeparam>
    /// <typeparam name="T1">Type of the first test argument.</typeparam>
    /// <param name="definition">Description of the test scenario.</param>
    /// <param name="expected">Expected return value.</param>
    /// <param name="arg1">First argument value.</param>
    /// <returns>
    /// Array of test parameters including the expected return value.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when current ArgsCode configuration is invalid.
    /// </exception>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1));

    /// <summary>
    /// Creates a <see cref="TestCaseData"/> for a value type return test case with two arguments.
    /// </summary>
    /// <typeparam name="TStruct">Type of expected return value.</typeparam>
    /// <typeparam name="T1">Type of the first test argument.</typeparam>
    /// <typeparam name="T2">Type of the second test argument.</typeparam>
    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1}"/>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2));

    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1, T2}" />
    /// <typeparam name="T3">The type of the third argument.</typeparam>
    /// <param name="arg3">The third argument.</param>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2, T3>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2, T3? arg3)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2, arg3));

    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1, T2, T3}" />
    /// <typeparam name="T4">The type of the fourth argument.</typeparam>
    /// <param name="arg4">The fourth argument.</param>
    /// <returns>An array of arguments.</returns>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2, T3, T4>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2, arg3, arg4));

    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1, T2, T3, T4}" />
    /// <typeparam name="T5">The type of the fifth argument.</typeparam>
    /// <param name="arg5">The fifth argument.</param>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2, T3, T4, T5>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5));

    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1, T2, T3, T4, T5}" />
    /// <typeparam name="T6">The type of the sixth argument.</typeparam>
    /// <param name="arg6">The sixth argument.</param>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2, T3, T4, T5, T6>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? args6)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, args6));

    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1, T2, T3, T4, T5, T6}" />
    /// <typeparam name="T7">The type of the seventh argument.</typeparam>
    /// <param name="arg7">The seventh argument.</param>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2, T3, T4, T5, T6, T7>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7));

    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1, T2, T3, T4, T5, T6, T7}" />
    /// <typeparam name="T8">The type of the eighth argument.</typeparam>
    /// <param name="arg8">The eighth argument.</param>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2, T3, T4, T5, T6, T7, T8>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7, T8? arg8)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

    /// <inheritdoc cref="TestDataReturnsToTestCaseData{TStruct, T1, T2, T3, T4, T5, T6, T7, t8}" />
    /// <typeparam name="T9">The type of the ninth argument.</typeparam>
    /// <param name="arg9">The ninth argument.</param>
    protected TestCaseData TestDataReturnsToTestCaseData<TStruct, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        string? testMethodName,
        string definition,
        TStruct expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7, T8? arg8, T9? arg9)
    where TStruct : struct
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataReturns(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
    #endregion

    #region TestDataThrowsToTestCaseData
    /// <summary>
    /// Creates a <see cref="TestCaseData"/> for a test case expecting an exception.
    /// </summary>
    /// <typeparam name="TException">Type of expected exception.</typeparam>
    /// <typeparam name="T1">Type of the first test argument.</typeparam>
    /// <param name="definition">Description of the test scenario.</param>
    /// <param name="expected">Expected exception instance.</param>
    /// <param name="arg1">First argument value.</param>
    /// <returns>
    /// Array of test parameters including the expected exception.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when current ArgsCode configuration is invalid.
    /// </exception>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1)
        where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1));

    /// <summary>
    /// Creates a <see cref="TestCaseData"/> for an exception test case with two arguments.
    /// </summary>
    /// <typeparam name="TException">Type of expected exception.</typeparam>
    /// <typeparam name="T1">Type of the first test argument.</typeparam>
    /// <typeparam name="T2">Type of the second test argument.</typeparam>
    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1}"/>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2)
        where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2));

    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1, T2}" />
    /// <typeparam name="T3">The type of the third argument.</typeparam>
    /// <param name="arg3">The third argument.</param>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2, T3>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2, T3? arg3)
    where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2, arg3));

    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1, T2, T3}" />
    /// <typeparam name="T4">The type of the fourth argument.</typeparam>
    /// <param name="arg4">The fourth argument.</param>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2, T3, T4>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4)
    where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2, arg3, arg4));

    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1, T2, T3, T4}" />
    /// <typeparam name="T5">The type of the fifth argument.</typeparam>
    /// <param name="arg5">The fifth argument.</param>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2, T3, T4, T5>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5)
    where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5));

    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1, T2, T3, T4, T5}" />
    /// <typeparam name="T6">The type of the sixth argument.</typeparam>
    /// <param name="arg6">The sixth argument.</param>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2, T3, T4, T5, T6>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6)
    where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6));

    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1, T2, T3, T4, T5, T6}" />
    /// <typeparam name="T7">The type of the seventh argument.</typeparam>
    /// <param name="arg7">The seventh argument.</param>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2, T3, T4, T5, T6, T7>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7)
    where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7));

    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1, T2, T3, T4, T5, T6, T7}" />
    /// <typeparam name="T8">The type of the eighth argument.</typeparam>
    /// <param name="arg8">The eighth argument.</param>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2, T3, T4, T5, T6, T7, T8>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7, T8? arg8)
    where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));

    /// <inheritdoc cref="TestDataThrowsToTestCaseData{TException, T1, T2, T3, T4, T5, T6, T7, T8}" />
    /// <typeparam name="T9">The type of the ninth argument.</typeparam>
    /// <param name="arg9">The ninth argument.</param>
    protected TestCaseData TestDataThrowsToTestCaseData<TException, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        string? testMethodName,
        string definition,
        TException expected,
        T1? arg1, T2? arg2, T3? arg3, T4? arg4, T5? arg5, T6? arg6, T7? arg7, T8? arg8, T9? arg9)
    where TException : Exception
    => TestDataToTestCaseData(
        testMethodName,
        CreateTestDataThrows(
            definition,
            expected,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
    #endregion
    #endregion
}
