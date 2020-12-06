'----------------------------------------------------------------------------
'INFO
'----------------------------------------------------------------------------
'Program:   Module 3, Exercise 2
'Date:      10/21/2020
'Author:    Morrison, Parker
'Operation: Using advanced math operations, determine the total cost and
'           interest on a loan by interpreting user input values.
'-----------------------------------------------------------------------------
'Change Log
' 10/21/2020 @ 4:25 PM - script created
'-----------------------------------------------------------------------------
'Date Programmer Change
' not applicable
'-----------------------------------------------------------------------------
Module Module1

    Sub Main()
        ' Again, storing values for efficiency.
        Dim principalLoan As Integer
        Dim annualInterest As Single
        Dim timePeriod As UShort

        Console.WriteLine("this program was designed to help determine the total values of a compound interest loan over a defined period of time.")
        Console.WriteLine("it's all in lowercase, since i didn't have time for capital letters.")
        Console.WriteLine($"{vbCrLf}first, enter the principal value of the loan.")
        principalLoan = Console.ReadLine()
        Console.WriteLine($"{vbCrLf}cool. now, enter the interest rate per year.")
        annualInterest = Console.ReadLine()
        Console.WriteLine($"{vbCrLf}finally, enter the amortization time in months.")
        timePeriod = Console.ReadLine()

        ' Yet again, initializing.
        Dim loanAmount As Double
        Dim totalInterest As Double
        Dim finalAmount As Double
        Dim finalInterest As Double
        ' Compound interest formula to find the loan amount.
        loanAmount = ((((annualInterest / 100) / 12) * principalLoan) / (1 - (1 + ((annualInterest / 100) / 12)) ^ (-timePeriod)) * timePeriod)
        ' Then, a simple formula to find how much of this was interest.
        totalInterest = (loanAmount - principalLoan)
        ' Two more values are used to round the decimals to the hundredth,
        ' simulating real currency.
        finalAmount = Math.Round(loanAmount, 2)
        finalInterest = Math.Round(totalInterest, 2)

        ' Final display; this is what the user sees once they're
        ' finished with their input.
        Console.WriteLine($"principal value = ${principalLoan}")
        Console.WriteLine($"yearly interest rate = {annualInterest}%")
        Console.WriteLine($"amortization period = {timePeriod} months")
        Console.WriteLine("=========================")
        Console.WriteLine($"the ultimate value of the loan was ${finalAmount}")
        Console.WriteLine($"and the interest totals to ${finalInterest}")
        Console.WriteLine("press any key to exit.")
        Console.ReadKey(True)
    End Sub

End Module
