Imports APCD.PeopleLibrary.Data

Namespace Utility

    Public Class APCDProgramUtility

        Public Shared Function GetLookupTable() As DataTable
            Dim objAPCDProgramDB As APCDProgramData = New APCDProgramData
            Return objAPCDProgramDB.GetLookupTable
        End Function

        Public Shared Function APCDProgramEmployee_GetByEmployeeID(ByVal intEmployeeID As Int32) As DataTable
            Dim objAPCDProgramDB As APCDProgramData = New APCDProgramData
            Return objAPCDProgramDB.APCDProgramEmployee_GetByEmployeeID(intEmployeeID)
        End Function

    End Class

End Namespace
