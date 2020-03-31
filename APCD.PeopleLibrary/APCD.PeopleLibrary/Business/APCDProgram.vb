Namespace Business

    Public Class APCDProgram

        Private m_intAPCDProgramID As Int32
        Private m_strAPCDProgramName As String
        Private m_strAPCDProgramDescription As String

        Public Property APCDProgramDescription() As String
            Get
                Return m_strAPCDProgramDescription
            End Get
            Set(ByVal value As String)
                m_strAPCDProgramDescription = value
            End Set
        End Property

        Public Property APCDProgramName() As String
            Get
                Return m_strAPCDProgramName
            End Get
            Set(ByVal value As String)
                m_strAPCDProgramName = value
            End Set
        End Property

        Public Property APCDProgramID() As Int32
            Get
                Return m_intAPCDProgramID
            End Get
            Set(ByVal value As Int32)
                m_intAPCDProgramID = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return MyBase.ToString()

        End Function

    End Class

End Namespace

