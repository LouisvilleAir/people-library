Imports System.Data.OleDb

Namespace Data

    Public Class EmployeeData

        Private m_cnAssetsAndApplications As OleDbConnection
        Private m_cmdEmployee As OleDbCommand
        Private m_daEmployee As OleDbDataAdapter

        Private m_prmintEmployeeID As OleDbParameter
        Private m_prmstrFirstName As OleDbParameter
        Private m_prmstrLastName As OleDbParameter
        Private m_prmstrMiddleName As OleDbParameter
        Private m_prmstrNickName As OleDbParameter
        Private m_prmstrUserName As OleDbParameter
        Private m_prmdtStartTime As OleDbParameter
        Private m_prmdtEndTime As OleDbParameter
        Private m_prmintReportsTo As OleDbParameter
        Private m_prmdtBeginDate As OleDbParameter
        Private m_prmdtEndDate As OleDbParameter
        Private m_prmdtAddDate As OleDbParameter
        Private m_prmintAddedBy As OleDbParameter

        Private Structure StoredProcedure
            Private _trash As String
            Const GetByUserName As String = "Employee_GetByUserName"
            Const GetByPrimaryKey As String = "Employee_GetByPrimaryKey"
        End Structure

        Private Structure ParameterName
            Private _trash As String
            Const EmployeeID As String = "@EmployeeID"
            Const FirstName As String = "@FirstName"
            Const LastName As String = "@LastName"
            Const MiddleName As String = "@MiddleName"
            Const NickName As String = "@NickName"
            Const UserName As String = "@UserName"
            Const StartTime As String = "@StartTime"
            Const EndTime As String = "@EndTime"
            Const ReportsTo As String = "@ReportsTo"
            Const BeginDate As String = "@BeginDate"
            Const EndDate As String = "@EndDate"
            Const AddDate As String = "@AddDate"
            Const AddedBy As String = "@AddedBy"
        End Structure

        Friend Function GetByPrimaryKey(ByVal intEmployeeID As Int32) As Business.Employee

            Dim drEmployee As OleDbDataReader
            Dim objEmployee As Business.Employee

            Try
                Me.m_prmintEmployeeID = New OleDbParameter
                With Me.m_prmintEmployeeID
                    .ParameterName = ParameterName.EmployeeID
                    .OleDbType = OleDbType.VarChar
                    .Value = intEmployeeID
                End With

                Me.m_cnAssetsAndApplications = New OleDbConnection(Globals.GlobalVariable.ConnectionString)
                Me.m_cmdEmployee = New OleDbCommand
                With Me.m_cmdEmployee
                    .Parameters.Add(Me.m_prmintEmployeeID)
                    .Connection = Me.m_cnAssetsAndApplications
                    .CommandText = StoredProcedure.GetByPrimaryKey
                    .CommandType = CommandType.StoredProcedure
                    .Connection.Open()
                    drEmployee = .ExecuteReader
                End With
                objEmployee = Me.LoadEmployeeObject(drEmployee)
                drEmployee.Close()
            Catch ex As Exception
                Throw New ApplicationException(ex.Message)
            End Try

            If (Not drEmployee.IsClosed) Then drEmployee.Close()
            If Me.m_cnAssetsAndApplications.State = ConnectionState.Open Then Me.m_cnAssetsAndApplications.Close()

            Return objEmployee

        End Function

        Friend Function GetByUserName(ByVal strUserName As String) As Business.Employee

            Dim drEmployee As OleDbDataReader
            Dim objEmployee As Business.Employee

            Try
                Me.m_prmstrUserName = New OleDbParameter
                With Me.m_prmstrUserName
                    .ParameterName = ParameterName.UserName
                    .OleDbType = OleDbType.VarChar
                    .Value = strUserName
                End With

                Me.m_cnAssetsAndApplications = New OleDbConnection(Globals.GlobalVariable.ConnectionString)
                Me.m_cmdEmployee = New OleDbCommand
                With Me.m_cmdEmployee
                    .Parameters.Add(Me.m_prmstrUserName)
                    .Connection = Me.m_cnAssetsAndApplications
                    .CommandText = StoredProcedure.GetByUserName
                    .CommandType = CommandType.StoredProcedure
                    .Connection.Open()
                    drEmployee = .ExecuteReader
                End With
                objEmployee = Me.LoadEmployeeObject(drEmployee)
                drEmployee.Close()
            Catch ex As Exception
                Throw New ApplicationException(ex.Message)
            End Try

            If (Not drEmployee.IsClosed) Then drEmployee.Close()
            If Me.m_cnAssetsAndApplications.State = ConnectionState.Open Then Me.m_cnAssetsAndApplications.Close()

            'now get the APCD Program IDs for the employee 
            'todo 20110218: make this cleaner later
            objEmployee.APCDProgramIDs = Utility.APCDProgramUtility.APCDProgramEmployee_GetByEmployeeID(objEmployee.EmployeeID)

            Return objEmployee

        End Function

        Private Function LoadEmployeeObject(ByVal dr As OleDbDataReader) As Business.Employee

            Dim obj As Business.Employee

            With dr
                If (.HasRows) Then
                    .Read()
                    obj = New Business.Employee
                    With obj
                        .EmployeeID = CInt(dr(0))
                        .FirstName = CStr(dr(1))
                        .LastName = CStr(dr(2))
                        If (Not IsDBNull(dr(3))) Then
                            .MiddleName = CStr(dr(3))
                        Else
                            .MiddleName = String.Empty
                        End If
                        .NickName = CStr(dr(4))
                        .UserName = CStr(dr(5))
                        .StartTime = CDate(dr(6))
                        .EndTime = CDate(dr(7))
                        .ReportsTo = CInt(dr(8))
                        .BeginDate = CDate(dr(9))
                        If (Not IsDBNull(dr(10))) Then
                            .EndDate = CDate(dr(10))
                        Else
                            .EndDate = Nothing
                        End If
                        .AddDate = CDate(dr(11))
                        .AddedBy = CInt(dr(12))
                    End With
                Else
                    obj = Nothing
                End If
            End With

            Return obj

        End Function
    End Class

End Namespace
