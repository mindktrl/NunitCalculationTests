# Calculation Tests

## Overview

	This test fixture contains four test methods, each testing a different calculation method in the Calculator class. 

	The Arrange section sets up the input values and expected results for the calculation being tested. 

	The Act section performs the actual calculation. 

	Finally, the Assert section checks that the actual result matches the expected result. 

	If the actual and expected results don't match, the test will fail.

## Test Data Generation

	There is a class `AutoFixtureCalculationTests.cs` that uses the AutoFixture library to generate variable values.

	This updated test fixture uses the AutoFixture library to generate random integer values for the a and b parameters in each test method.

	The expectedResult variable is calculated based on the randomly generated values. 

	This allows the test to be more flexible and cover a wider range of inputs. 

	The Setup method is used to create a new Fixture instance before each test method is run, ensuring that the test is fully isolated and repeatable.

    There is a class `FakerDotNetCalculationTests.cs` that is using the FakerCS library to generate random integer values using the RandomNumber class instead of Autofixture's `Fixture.Create<int>().`