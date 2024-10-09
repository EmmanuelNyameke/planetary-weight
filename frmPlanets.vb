' Program Name: Planet Weight
' Date: September 30, 2024
' Author: K Bola
' Purpose: This application calculates a user's weight in pounds and kilograms on venus or mars
Public Class frmPlanets
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Const dblVenus As Double = 0.907
        Const dblMars As Double = 0.377
        Const dblKG As Double = 0.454
        Dim dblTotalPoundsWeight As Double
        Dim dblTotalKGWeight As Double
        If (IsNumeric(txtWeight.Text)) Then
            Dim dblWeight As Double = Convert.ToDouble(txtWeight.Text)
            If (dblWeight > 0 And radVenus.Checked) Then
                dblTotalPoundsWeight = dblWeight * dblVenus
                dblTotalKGWeight = dblWeight * dblKG
                lblDisplayWeight.Text = "Your Weight on Venus is " & dblTotalPoundsWeight.ToString("N") & "lbs (in pounds) but" & vbCrLf & dblTotalKGWeight.ToString("N") & "kg (in kilogram)."

            ElseIf (dblWeight > 0 And radMars.Checked) Then
                dblTotalPoundsWeight = dblWeight * dblMars
                dblTotalKGWeight = dblWeight * dblKG
                lblDisplayWeight.Text = "Your Weight on Venus is " & dblTotalPoundsWeight.ToString("N") & "lbs (in pounds) but" & vbCrLf & dblTotalKGWeight.ToString("N") & "kg (in kilogram)."

            Else
                MsgBox("Please Enter a Number Greater Than Zero", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
                txtWeight.Clear()
                txtWeight.Focus()
            End If
        Else
            MsgBox("Please Enter a number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
            txtWeight.Clear()
            txtWeight.Focus()
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplayWeight.Text = ""
        txtWeight.Clear()
        txtWeight.Focus()
        radVenus.Checked = True
    End Sub
    Private Sub frmPlanets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayWeight.Text = ""
    End Sub
End Class
