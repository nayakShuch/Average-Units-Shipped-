
'File Name:     LAB 1 - Average Units Shipped
'Purpose:       To create a Windows .NET application according to client requirements,
'               that accepts daily units shipped For a week And Then calculates and displays the weekly average
'Author:        Shuchi Nayak
'Last Edited:   30th May 2020
Option Strict On
Public Class frmAverageUnitsShipped

    '**********************DECLARATIONS********************************
    Dim unitsShipped(6) As Integer                  'Array of variables for holding user input
    Dim averageUnits As Double                      'Variable for holding the required output
    Dim counter As Integer = 0                      'Counter for valid inputs

    ''' <summary>
    ''' Event Handler for btnExit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                  'Exit the application
    End Sub

    ''' <summary>
    ''' Event Handler for btnReset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUnits.Clear()            'Clear the entry and output labels/textboxes
        txtUnitsDisplay.Clear()
        lblOutput.Text = ""
        lblDays.Text = "Day 1"      'Reset the day and counter
        counter = 0
        txtUnits.Enabled = True     'Unlock btnEnter and textbox for entry
        btnEnter.Enabled = True
        txtUnits.Focus()            'Focus on textbox for entry
    End Sub

    ''' <summary>
    ''' Event Handler for btnEnter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click





        '***************************INPUT**********************************
        If IsNumeric(Me.txtUnits.Text) Then                                                     'Numeric validation

            If Integer.TryParse(txtUnits.Text, unitsShipped(counter)) Then                      'Integral validation

                If unitsShipped(counter) > 0 And unitsShipped(counter) < 5000 Then              'Data entry range validation

                    txtUnitsDisplay.Text += txtUnits.Text + vbCrLf                              'Loop for displaying list of daily units and day counter
                    txtUnits.Clear()
                    counter += 1
                    lblDays.Text = "Day " + Convert.ToString(counter + 1)



                Else                                                                            'Data entry range error message
                    MsgBox("Please enter units between the range 0-5000")
                    txtUnits.Focus()
                End If

            Else                                                                                'Whole number error message
                MsgBox("Please enter a whole number for Units")
                txtUnits.Focus()
            End If

        Else                                                                                    'Numeric error message
            MsgBox("Please enter a numeric value for Units")
            txtUnits.Focus()
        End If





        '***************************PROCESSING**********************************
        averageUnits = unitsShipped.Average
        'Formula for calculating average of array elements



        '*****************************OUTPUT************************************
        If counter = 7 Then                                     'When array has been filled
            lblDays.Text = "Day 7"
            btnEnter.Enabled = False                            'Lock btnEnter and user entry
            txtUnits.Enabled = False
            lblOutput.Text = "Average per day: " + Convert.ToString(Math.Round((averageUnits), 2))      'Display rounded off output in the output label
        End If


    End Sub
End Class
