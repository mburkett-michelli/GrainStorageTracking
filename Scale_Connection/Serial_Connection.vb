Imports System
Imports System.Timers

Public Class Serial_Connection
    Dim ScaleOk As Boolean
    Public Motion As Boolean = False
    Public Status As String
    Public Weight As Double
    Public StoredWeight1 As Integer
    Public StoredWeight2 As Integer
    Public SerialError As String = ""
    Public InString As String = ""

    Public sSerialPort As String = ""  'Matt added
    Public sType As String = ""   'Matt added
    Dim StatusChar As Array = {"|", "/", "--", "\", "|", "/", "--", "\"}
    Dim StatusPointer As Integer = 0

    'Public WithEvents Logger As New ErrorLog.LogError

    Delegate Sub SetTextCallback(ByVal text As String)
    Dim _UpdateWeight As Boolean


    Public Property UpdateWeight As Boolean

        Get
            UpdateWeight = _UpdateWeight

        End Get

        Set(ByVal value As Boolean)

            _UpdateWeight = value

            If _UpdateWeight = False Then
                Me.ErrorTmr.Stop()
            End If

        End Set

    End Property

    Dim WithEvents UpdateTimer As New System.Timers.Timer

    Public Event StatusChanged()

    Public RawScaleData As String

    Public WithEvents ScaleSerialPort As System.IO.Ports.SerialPort
    Public WithEvents ErrorTmr As New System.Timers.Timer
    Public WithEvents ReconnectTmr As New System.Timers.Timer

    Public Simulate As Boolean

    Public WithEvents SimulatedMotionTmr As New System.Timers.Timer

    Public Sub New(ByVal sSerialPort As String, Connection_Type As String, UpdateRate As Integer, Simulate_Scale As Boolean) 'Serial Port is expecting comx, Type is expecting scale or rfid

        sType = Connection_Type
        If sType = "Condec" Or sType = "GSE" Then
            ScaleSerialPort = New System.IO.Ports.SerialPort
            ScaleSerialPort.PortName = sSerialPort
            If UpdateRate < 500 Then
                UpdateTimer.Interval = 500
            Else
                UpdateTimer.Interval = UpdateRate
            End If
        End If
            Simulate = Simulate_Scale


    End Sub

    Public Sub Connect()

        If UpdateTimer.Interval < 500 Then
            UpdateTimer.Interval = 500
        End If
        ErrorTmr.Interval = 10000
        ReconnectTmr.Interval = 2000
        ReconnectTmr.Enabled = False

        Try

            If Simulate = False Then

                Me.ScaleSerialPort.NewLine = Chr(13)
                Me.ScaleSerialPort.BaudRate = "9600"
                Me.ScaleSerialPort.DataBits = "8"
                Me.ScaleSerialPort.Parity = IO.Ports.Parity.None
                Me.ScaleSerialPort.StopBits = "1"

                If sType = "GSE" Then

                    Me.ScaleSerialPort.Handshake = IO.Ports.Handshake.XOnXOff

                Else

                    Me.ScaleSerialPort.Handshake = IO.Ports.Handshake.None

                End If

                If Me.ScaleSerialPort.IsOpen Then Me.ScaleSerialPort.Close()

                Me.ScaleSerialPort.Open()
                Me.Status = "Connecting To Scale"
                Me.ScaleOk = False

                UpdateWeight = True

                ErrorTmr.Start()
                Me.UpdateTimer.Start()

            Else

                UpdateWeight = False
                Me.ScaleOk = True
                Me.Status = ""

                Me.UpdateTimer.Stop()
                Me.ErrorTmr.Stop()

            End If

        Catch ex As Exception

            Status = "Scale Error"
            ScaleOk = False

            ErrorTmr.Stop()

            Me.ScaleOk = False
            Me.Status = "Lost Connection To Scale"

        End Try

        RaiseEvent StatusChanged()

    End Sub

    Public Sub SimulateWeightChange(ByVal NewWeight As Integer)


        Me.Weight = NewWeight
        Motion = True
        Me.Status = "Motion"
        Me.SimulatedMotionTmr.Start()
        RaiseEvent StatusChanged()

    End Sub

    Public Sub CloseConnection()

        UpdateTimer.Enabled = False
        UpdateTimer.Stop()
        ReconnectTmr.Enabled = False
        ReconnectTmr.Stop()
        ErrorTmr.Enabled = False
        ErrorTmr.Stop()

    End Sub



    Public ReadOnly Property Current_Scale_Weight
        Get
            If Me.ScaleOk Then
                Current_Scale_Weight = Me.Weight
            Else
                Current_Scale_Weight = 0
            End If

        End Get
    End Property


    Public ReadOnly Property Simulated As Boolean
        Get
            Simulated = Simulate
        End Get
    End Property


    Public ReadOnly Property Connected As Boolean
        Get
            Connected = Simulate Or Me.ScaleOk
        End Get
    End Property



    Public ReadOnly Property SerialPort As String
        Get

            SerialPort = sSerialPort

        End Get
    End Property


    Public ReadOnly Property OkToWeigh As Boolean

        Get

            OkToWeigh = Me.ScaleOk And Motion = False

        End Get

    End Property

    Public ReadOnly Property ScaleError As Boolean
        Get
            ScaleError = Not Me.ScaleOk
        End Get
    End Property


    Public Function SplitWeigh() As Boolean

        If Me.Motion = False And ScaleOk Then

            If Me.StoredWeight1 > 0 Then
                Me.StoredWeight2 = Me.Weight
            Else
                Me.StoredWeight1 = Me.Weight
            End If

            RaiseEvent StatusChanged()

            Return True

        Else

            Return False

        End If

    End Function

    Public ReadOnly Property ScaleStatusChar As String
        Get
            Return Me.StatusChar(StatusPointer)
        End Get
    End Property

    Public ReadOnly Property ScaleStatus As String
        Get
            Return Me.Status
        End Get
    End Property


    Public ReadOnly Property HasMotion As Boolean

        Get
            HasMotion = Me.Motion
        End Get

    End Property

    Private Sub ReconnectTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReconnectTmr.Elapsed

        Me.ReconnectTmr.Stop()
        Connect()

    End Sub


    Private Sub ErrorTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ErrorTmr.Elapsed

        Me.ErrorTmr.Stop()
        Me.UpdateTimer.Stop()
        Me.ReconnectTmr.Enabled = True
        Me.ReconnectTmr.Start()

        Me.ScaleSerialPort.Close()    'Close the serial port and re-initialzie after 2 seconds.

        Me.ScaleOk = False
        Me.Status = "Lost Connection To Scale"
        RaiseEvent StatusChanged()

    End Sub

    Private Sub SimulatedMotionTmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimulatedMotionTmr.Elapsed

        Me.Motion = False
        Me.SimulatedMotionTmr.Stop()
        Me.Status = ""
        RaiseEvent StatusChanged()

    End Sub

    Private Sub ScaleSerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles ScaleSerialPort.DataReceived

    End Sub


    Public Sub ClearBuffer()
        Try
            If Me.ScaleSerialPort.IsOpen Then Dim S As String = Me.ScaleSerialPort.ReadExisting
        Catch ex As Exception

        End Try

    End Sub


    Private Sub UpdateTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles UpdateTimer.Elapsed

        Try

            If Me.ScaleSerialPort.IsOpen Then

                Try

                    InString += ScaleSerialPort.ReadExisting
                    Dim InstrArray() As String = InString.Split(Chr(13))

                    If InstrArray.Length > 2 Then

                        InString = InstrArray(InstrArray.Length - 2)

                        If UpdateWeight And InString <> "" Then

                            Dim NegativeWt As Boolean
                            RawScaleData = InString

                            Dim InStringArray() = InString.ToCharArray
                            Dim CleanWt As String = ""

                            For Each OneChar As Char In InStringArray

                                Dim OneInt As Integer

                                If OneChar = "." Then

                                    CleanWt += OneChar.ToString

                                ElseIf Integer.TryParse(OneChar, OneInt) Then

                                    CleanWt += OneInt.ToString

                                End If

                            Next

                            Dim Wt As Double = 0

                            Wt = Convert.ToDouble(CleanWt)

                            Me.Weight = Wt
                            Motion = InString.ToUpper.Contains("M")
                            NegativeWt = InString.Contains("-")

                            If Motion Then
                                Me.Status = "Motion"
                            Else
                                Me.Status = ""
                            End If
                            If NegativeWt Then
                                Me.Weight = Me.Weight * -1
                            End If
                            ScaleOk = True
                            Me.ErrorTmr.Stop()
                            Me.ErrorTmr.Start()
                            If StatusPointer < 7 Then
                                StatusPointer += 1
                            Else
                                StatusPointer = 0
                            End If
                            If UpdateWeight Then RaiseEvent StatusChanged()

                            InString = ""

                        End If

                    End If

                Catch ex As Exception

                End Try

            End If

        Catch ex As Exception

        End Try
        RaiseEvent StatusChanged()
    End Sub


End Class
