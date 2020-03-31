Imports APCD.PeopleLibrary.Data


Namespace Utility

    Public Class EmployeeUtility

        Public Shared Function GetByPrimaryKey(ByVal intEmployeeID As Int32) As Business.Employee

            Dim objEmployeeDB As EmployeeData = New EmployeeData
            Return objEmployeeDB.GetByPrimaryKey(intEmployeeID)

        End Function

        Public Shared Function GetByUserName(ByVal strUserName As String) As Business.Employee

            Dim objEmployeeDB As EmployeeData = New EmployeeData
            Return objEmployeeDB.GetByUserName(strUserName)

        End Function

    End Class

End Namespace
