Imports System.Data.OleDb

Namespace Data

    Public Class EmployeeTelephoneNumberData

        Private Structure StoredProcedure
            Private _trash As String
            Const GetWorkByEmployeeID As String = "EmployeeTelephoneNumber_GetWorkByEmployeeID"
        End Structure

        Private Structure ParameterName
            Private _trash As String
            Const EmployeeID As String = "@EmployeeID"
        End Structure

        Friend Function GetWorkByEmployeeID(ByVal employeeID As Int32) As String

            Dim cn As OleDbConnection
            Dim workPhone As String = String.Empty
            Try
                Dim employeeIDParameter As New OleDbParameter
                With employeeIDParameter
                    .ParameterName = ParameterName.EmployeeID
                    .OleDbType = OleDbType.Integer
                    .Value = employeeID
                End With

                cn = New OleDbConnection(Globals.GlobalVariable.ConnectionString)
                Dim cmd As New OleDbCommand
                With cmd
                    .Parameters.Add(employeeIDParameter)
                    .Connection = cn
                    .CommandText = StoredProcedure.GetWorkByEmployeeID
                    .CommandType = CommandType.StoredProcedure
                    .Connection.Open()
                    workPhone = .ExecuteScalar
                End With
            Catch ex As Exception
                Throw New ApplicationException(ex.Message)
            End Try

            If cn.State = ConnectionState.Open Then cn.Close()

            Return workPhone

        End Function

    End Class

End Namespace
