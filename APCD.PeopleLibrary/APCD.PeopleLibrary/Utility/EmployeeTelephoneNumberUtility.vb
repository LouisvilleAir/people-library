Imports APCD.PeopleLibrary.Data

Namespace Utility

    Public Class EmployeeTelephoneNumberUtility

        Public Shared Function GetWorkByEmployeeID(ByVal employeeID As Int32) As String
            Dim obj As New EmployeeTelephoneNumberData
            Return obj.GetWorkByEmployeeID(employeeID)
        End Function

    End Class

End Namespace
