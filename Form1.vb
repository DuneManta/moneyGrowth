Public Class Form1
    'Global variables
    Dim decAmount As Decimal
    Dim sngGrowthRate As Single
    Dim decFinalAmount As Decimal

    Private Sub btnFutureValue_Click(sender As Object, e As EventArgs) Handles btnFutureValue.Click
        'Variables
        Dim shoCycles As Short
        Dim decGrowthAmount As Decimal

        'Get input
        decAmount = Convert.ToDecimal(txtAmount.Text)
        sngGrowthRate = Convert.ToSingle(txtGrowth.Text)
        shoCycles = Convert.ToInt16(txtCycles.Text)
        'Convert sngGrowthRate to percentage value
        sngGrowthRate /= 100
        'Set initial decFinalAmount to entered amount
        decFinalAmount = decAmount

        'Loop for number of cycles
        For i = 1 To shoCycles
            decGrowthAmount = decFinalAmount * sngGrowthRate
            decFinalAmount += decGrowthAmount
        Next i

        'Display results
        lblAnswer.Text = decFinalAmount.ToString("c")
    End Sub

    Private Sub btnTimeToTarget_Click(sender As Object, e As EventArgs) Handles btnTimeToTarget.Click
        'Variables
        Dim decTarget As Decimal
        Dim decGrowthAmount As Decimal
        Dim shoFinalCycles As Short

        'Get input
        decAmount = Convert.ToDecimal(txtAmount.Text)
        sngGrowthRate = Convert.ToSingle(txtGrowth.Text)
        decTarget = Convert.ToDecimal(txtTarget.Text)
        'Convert sngGrowth to percentage value
        sngGrowthRate /= 100
        'Set initial decFinalAmount to entered amount
        decFinalAmount = decAmount

        'Loop until target is met
        Do While decFinalAmount < decTarget
            decGrowthAmount = decFinalAmount * sngGrowthRate
            decFinalAmount += decGrowthAmount
            shoFinalCycles += 1
        Loop

        'Display results
        lblAnswer.Text = "Number of cycles: " & shoFinalCycles.ToString
    End Sub
End Class
