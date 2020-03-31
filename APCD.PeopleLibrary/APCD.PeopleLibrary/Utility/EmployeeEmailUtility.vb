Imports APCD.PeopleLibrary.Data

Namespace Utility

    Public Class EmployeeEmailUtility

        Public Shared Function GetByEmployeeID(ByVal employeeID As Int32) As String
            Dim obj As New EmployeeEmailData
            Return obj.GetByEmployeeID(employeeID)
        End Function

    End Class

End Namespace
