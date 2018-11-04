Class MainWindow
    
    Function randnum()
        Dim a As Integer() = {2, 2, 4}
        Dim b As Integer = CInt(Math.Floor(3 * Rnd()))
        Return a(b)
    End Function
    
    
    Function randpos(ByVal len As Integer)
        Dim b As Integer = CInt(Math.Floor((len) * Rnd())) + 1
        Return b
    End Function
    Sub swap(ByRef x As Integer, ByRef y As Integer)
        Dim i As Integer = x
        x = y
        y = i
    End Sub
    Sub display(ByRef a As Integer(,))
        Dim b As String(,) = {{"", "", ""}, {"", "", ""}, {"", "", ""}}
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                b(i, j) = CStr(a(i, j))
                If b(i, j) = "0" Then
                    b(i, j) = ""
                End If
            Next
        Next
        Label11.Content = b(0, 0)
        Label12.Content = b(0, 1)
        Label13.Content = b(0, 2)
        Label21.Content = b(1, 0)
        Label22.Content = b(1, 1)
        Label23.Content = b(1, 2)
        Label31.Content = b(2, 0)
        Label32.Content = b(2, 1)
        Label33.Content = b(2, 2)


    End Sub

    
    Dim a As Integer(,) = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

        Dim b As Integer = CInt(Math.Floor(3 * Rnd()))
        Dim c As Integer = CInt(Math.Floor(3 * Rnd()))
        a(b, c) = randnum()
        display(a)
    End Sub


    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.Key
            Case Key.Right
                For i As Integer = 0 To 2
                    For j As Integer = 0 To 1
                        If j = 0 Then
                            j = 2
                        Else
                            j = 1
                        End If
                        If a(i, j) = a(i, j - 1) Then
                            a(i, j) += a(i, j - 1)
                            a(i, j - 1) = 0
                            Exit For
                        ElseIf a(i, 2) = a(i, 0) Then
                            a(i, 2) += a(i, 0)
                            a(i, 0) = 0
                            Exit For
                        End If
                        If j = 2 Then
                            j = 0
                        Else
                            j = 1
                        End If
                    Next
                    For j = 0 To 1
                        If j = 0 Then
                            j = 2
                        Else
                            j = 1
                        End If
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i, j - 1))
                        End If
                        If j = 2 Then
                            j = 0
                        Else
                            j = 1
                        End If
                    Next
                    For j = 0 To 1
                        If j = 0 Then
                            j = 2
                        Else
                            j = 1
                        End If
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i, j - 1))
                        End If
                        If j = 2 Then
                            j = 0
                        Else
                            j = 1
                        End If
                    Next
                Next
            Case Key.Left
                For i As Integer = 0 To 2
                    For j As Integer = 0 To 1
                        If a(i, j) = a(i, j + 1) Then
                            a(i, j) += a(i, j + 1)
                            a(i, j + 1) = 0
                            Exit For
                        ElseIf a(i, 0) = a(i, 2) Then
                            a(i, 0) += a(i, 2)
                            a(i, 2) = 0
                            Exit For
                        End If

                    Next
                    For j = 0 To 1
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i, j + 1))
                        End If
                    Next
                    For j = 0 To 1
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i, j + 1))
                        End If
                    Next
                Next
            Case Key.Up
                For j As Integer = 0 To 2
                    For i As Integer = 0 To 1
                        If a(i, j) = a(i + 1, j) Then
                            a(i, j) += a(i + 1, j)
                            a(i + 1, j) = 0
                            Exit For
                        ElseIf a(2, j) = a(0, j) Then
                            a(2, j) += a(0, j)
                            a(0, j) = 0
                            Exit For
                        End If

                    Next
                    For i = 0 To 1
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i + 1, j))
                        End If
                    Next
                    For i = 0 To 1
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i + 1, j))
                        End If
                    Next
                Next
            Case Key.Down
                For j As Integer = 0 To 2
                    For i As Integer = 0 To 1
                        If i = 0 Then
                            i = 2
                        Else
                            i = 1
                        End If
                        If a(i, j) = a(i - 1, j) Then
                            a(i, j) += a(i - 1, j)
                            a(i - 1, j) = 0
                            Exit For
                        ElseIf a(0, j) = a(2, j) Then
                            a(0, j) += a(2, j)
                            a(2, j) = 0
                            Exit For
                        End If
                        If i = 2 Then
                            i = 0
                        Else
                            i = 1
                        End If
                    Next
                    For i = 0 To 1
                        If i = 0 Then
                            i = 2
                        Else
                            i = 1
                        End If
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i - 1, j))
                        End If
                        If i = 2 Then
                            i = 0
                        Else
                            i = 1
                        End If
                    Next
                    For i = 0 To 1
                        If i = 0 Then
                            i = 2
                        Else
                            i = 1
                        End If
                        If a(i, j) = 0 Then
                            swap(a(i, j), a(i - 1, j))
                        End If
                        If i = 2 Then
                            i = 0
                        Else
                            i = 1
                        End If
                    Next
                Next
        End Select
        Dim r As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim p As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim k As Integer = 0
        Dim s As Integer = 0
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If a(i, j) = 0 Then
                    k += 1
                    r(k) = i
                    p(k) = j
                End If
            Next
        Next
        If k <> 0 Then
            Dim c As Integer = randpos(k)
            a(r(c), p(c)) = randnum()
        End If
        display(a)
    End Sub
End Class