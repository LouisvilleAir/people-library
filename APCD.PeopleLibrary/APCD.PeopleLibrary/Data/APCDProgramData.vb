Imports System.Data.OleDb
Imports APCD.PeopleLibrary.Business
Imports APCD.PeopleLibrary.Constant
Imports APCD.PeopleLibrary.Globals
Imports System.Text

Namespace Data

    Public Class APCDProgramData

        Private m_cnDocumentManager As OleDbConnection
        Private m_cmdAPCDProgram As OleDbCommand
        Private m_adpAPCDProgram As OleDbDataAdapter

        'parameters
        Private m_prmintAPCDProgramID As OleDbParameter
        Private m_prmstrAPCDProgramName As OleDbParameter
        Private m_prmstrAPCDProgramDescription As OleDbParameter

        Private Structure StoredProcedure
            Private _trash As String
            Const GetLookupTable As String = "APCDProgram_GetLookupTable"


            '
            Const APCDProgramEmployee_GetByEmployeeID As String = "APCDProgramEmployee_GetByEmployeeID"

        End Structure

        Private Structure ParameterName
            Private _trash As String
            Const APCDProgramID As String = "@APCDProgramID"
            Const APCDProgramName As String = "@APCDProgramName"
            Const APCDProgramDescription As String = "@APCDProgramDescription"
        End Structure

        Friend Function GetLookupTable() As DataTable

            Dim dtbLookupTable As DataTable = New DataTable(APCDProgramConstants.DatabaseTableName.APCDProgram)

            Try
                Me.m_cnDocumentManager = New OleDbConnection(Globals.GlobalVariable.ConnectionString)
                Me.m_cmdAPCDProgram = New OleDbCommand
                With Me.m_cmdAPCDProgram
                    .Connection = Me.m_cnDocumentManager
                    .CommandText = StoredProcedure.GetLookupTable
                    .CommandType = CommandType.StoredProcedure
                End With
                Me.m_adpAPCDProgram = New OleDbDataAdapter(Me.m_cmdAPCDProgram)
                Me.m_adpAPCDProgram.Fill(dtbLookupTable)
            Catch ex As Exception
                Throw New ApplicationException(ex.Message)
            Finally
                If Me.m_cnDocumentManager.State = ConnectionState.Open Then Me.m_cnDocumentManager.Close()
            End Try

            Return dtbLookupTable

        End Function

        Friend Function APCDProgramEmployee_GetByEmployeeID(ByVal intEmployeeID As Int32) As DataTable

            Dim prmintEmployeeID As OleDbParameter = New OleDbParameter
            Dim dtbAPCDProgramEmployee As DataTable = New DataTable

            Try
                With prmintEmployeeID
                    .ParameterName = Constant.EmployeeConstant.DatabaseField.EmployeeID
                    .OleDbType = OleDbType.Integer
                    .Value = intEmployeeID
                End With

                Me.m_cnDocumentManager = New OleDbConnection(Globals.GlobalVariable.ConnectionString)
                Me.m_cmdAPCDProgram = New OleDbCommand
                With Me.m_cmdAPCDProgram
                    .Connection = Me.m_cnDocumentManager
                    .Parameters.Add(prmintEmployeeID)
                    .CommandText = StoredProcedure.APCDProgramEmployee_GetByEmployeeID
                    .CommandType = CommandType.StoredProcedure
                End With
                Me.m_adpAPCDProgram = New OleDbDataAdapter
                Me.m_adpAPCDProgram.SelectCommand = Me.m_cmdAPCDProgram
                Me.m_adpAPCDProgram.Fill(dtbAPCDProgramEmployee)
            Catch ex As Exception
                Throw New ApplicationException(ex.Message)
            Finally
                If Me.m_cnDocumentManager.State = ConnectionState.Open Then Me.m_cnDocumentManager.Close()
            End Try

            Return dtbAPCDProgramEmployee

        End Function

    End Class

End Namespace
