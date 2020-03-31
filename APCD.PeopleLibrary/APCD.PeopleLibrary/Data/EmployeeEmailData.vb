Imports System.Data.OleDb

Namespace Data

    Public Class EmployeeEmailData

        Private Structure StoredProcedure
            Private _trash As String
            Const GetByEmployeeID As String = "EmployeeEmail_GetByEmployeeID"
        End Structure

        Private Structure ParameterName
            Private _trash As String
            Const EmployeeID As String = "@EmployeeID"
        End Structure

        Friend Function GetByEmployeeID(ByVal employeeID As Int32) As String

            Dim cn As OleDbConnection
            Dim email As String = String.Empty
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
                    .CommandText = StoredProcedure.GetByEmployeeID
                    .CommandType = CommandType.StoredProcedure
                    .Connection.Open()
                    email = CStr(.ExecuteScalar)
                End With
            Catch ex As Exception
                Throw New ApplicationException(ex.Message)
            End Try

            If cn.State = ConnectionState.Open Then cn.Close()

            Return email

        End Function

    End Class
End Namespace
