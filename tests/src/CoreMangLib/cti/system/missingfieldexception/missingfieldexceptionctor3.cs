using System;
using System.Collections.Generic;
/// <summary>
///ctor(System.String,System.Exception)
/// </summary>
public class MissingFieldExceptionCtor3
{
    public static int Main()
    {
        MissingFieldExceptionCtor3 MissingFieldExceptionCtor3 = new MissingFieldExceptionCtor3();

        TestLibrary.TestFramework.BeginTestCase("MissingFieldExceptionCtor3");
        if (MissingFieldExceptionCtor3.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new instance of MissingFieldException.");
        try
        {
            string expectValue = "HELLO";
            ArgumentException notFoundException = new ArgumentException();
            MissingFieldException myException = new MissingFieldException(expectValue, notFoundException);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("001.1", "MissingFieldException instance can not create correctly.");
                retVal = false;
            }
            if (myException.Message != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.2", "the Message should return " + expectValue);
                retVal = false;
            }
            if (!(myException.InnerException is ArgumentException))
            {
                TestLibrary.TestFramework.LogError("001.3", "the InnerException should return ArgumentException.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: the parameter string is null.");
        try
        {
            string expectValue = null;
            ArgumentException dpoExpection = new ArgumentException();
            MissingFieldException myException = new MissingFieldException(expectValue, dpoExpection);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("002.1", "MissingFieldException instance can not create correctly.");
                retVal = false;
            }
            if (myException.Message == expectValue)
            {
                TestLibrary.TestFramework.LogError("002.2", "the Message should return the default value.");
                retVal = false;
            }
            if (!(myException.InnerException is ArgumentException))
            {
                TestLibrary.TestFramework.LogError("002.3", "the InnerException should return MissingFieldException.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}
