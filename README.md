# Interest rate calculator

## Purpose
This simple app is designed to calculate money and interest rates.
It has two simple yet different functions:

+ Calculate a final value based on an initial value and a set interest rate based on a number of cycles
+ Calculate how many cycles it would take to reach a specified amount based on an initial amount and interest rate

## How to run
This project is constructed using VBS language, and is best run within *Microsoft Visual Studio* using the built in runtime environment.
The interface is fairly simple, with a few labeled input fields marking locations for the initial input amounts and buttons to fire the individual calculations.

## Example of running app
[Freshly started instance of the app](running.PNG)

## Code sample from the app
        For i = 1 To shoCycles
            decGrowthAmount = decFinalAmount * sngGrowthRate
            decFinalAmount += decGrowthAmount
        Next i

[**Link to my GitHub profile**](https://github.com/DuneManta)