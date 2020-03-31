Imports System.Windows.Forms

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        APCD.PeopleLibrary.Globals.GlobalVariable.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\mfarris\Documents\Projects\Common\People.mdb"
    End Sub

    Private Sub FileMenu_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu_Exit.Click
        Application.Exit()
    End Sub


    Private Sub ClassMenu_Employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassMenu_Employee.Click

        EmployeeForm.MdiParent = Me
        EmployeeForm.Show()

    End Sub

End Class
