Public Class EmployeeForm

    Private Sub GetByUserNameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetByUserNameButton.Click
        Dim username As String = InputBox("Enter username: ")
        Me.DataGridView1.DataSource = APCD.PeopleLibrary.Utility.EmployeeUtility.GetByUserName(username)
    End Sub

    Private Sub GetByPrimaryKeyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetByPrimaryKeyButton.Click
        Dim primarykey As String = InputBox("Enter username: ")
        Me.DataGridView1.DataSource = APCD.PeopleLibrary.Utility.EmployeeUtility.GetByUserName(primarykey)
    End Sub


End Class