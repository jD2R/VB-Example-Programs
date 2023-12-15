Module ShoppingInfo
    Public Const TAX_RATE As Decimal = 0.06D

    Public Const PRINT_BOOK_ONE As Decimal = 11.95D
    Public Const PRINT_BOOK_TWO As Decimal = 14.5D
    Public Const PRINT_BOOK_THREE As Decimal = 29.95D
    Public Const PRINT_BOOK_FOUR As Decimal = 18.5D

    Public Const AUDIO_BOOK_ONE As Decimal = 29.95D
    Public Const AUDIO_BOOK_TWO As Decimal = 14.5D
    Public Const AUDIO_BOOK_THREE As Decimal = 12.95D
    Public Const AUDIO_BOOK_FOUR As Decimal = 11.5D

    Public strBookTitle As String

    Public Function GetPrice(strTitle As String) As Decimal
        Select Case strTitle
            Case "I Did It Your Way (Print)"
                Return PRINT_BOOK_ONE
            Case "The History of Scotland (Print)"
                Return PRINT_BOOK_TWO
            Case "Learn Calculus in One Day (Print)"
                Return PRINT_BOOK_THREE
            Case "Feel the Stress (Print)"
                Return PRINT_BOOK_FOUR

            Case "Learn Calculus in One Day (Audio)"
                Return AUDIO_BOOK_ONE
            Case "Relaxation Techniques (Audio)"
                Return AUDIO_BOOK_TWO
            Case "The History of Scotland (Audio)"
                Return AUDIO_BOOK_THREE
            Case "The Science of Body Language (Audio)"
                Return AUDIO_BOOK_FOUR
        End Select

        Return 0D
    End Function

End Module
