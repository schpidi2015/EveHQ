﻿'==============================================================================
'
' EveHQ - An Eve-Online™ character assistance application
' Copyright © 2005-2015  EveHQ Development Team
'
' This file is part of EveHQ.
'
' The source code for EveHQ is free and you may redistribute 
' it and/or modify it under the terms of the MIT License. 
'
' Refer to the NOTICES file in the root folder of EVEHQ source
' project for details of 3rd party components that are covered
' under their own, separate licenses.
'
' EveHQ is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the MIT 
' license below for details.
'
' ------------------------------------------------------------------------------
'
' The MIT License (MIT)
'
' Copyright © 2005-2015  EveHQ Development Team
'
' Permission is hereby granted, free of charge, to any person obtaining a copy
' of this software and associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
' copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in
' all copies or substantial portions of the Software.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
' THE SOFTWARE.
'
' ==============================================================================

Imports System.Text
Imports EveHQ.Core
Imports System.Net.Mail

Namespace Forms

    Public Class FrmException

        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        Private Sub btnCopyText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopyText.Click
            Dim errReport As New StringBuilder
            errReport.AppendLine("*EveHQ Error Report*")
            errReport.AppendLine("")
            errReport.AppendLine("EveHQ Version: " & My.Application.Info.Version.ToString)
            errReport.AppendLine("Date: " & Now.ToString)
            errReport.AppendLine("Error: " & lblError.Text)
            errReport.AppendLine("----")
            errReport.AppendLine("\\{panel:title=StackTrace|borderStyle=dashed|bordercolor=#ccc|titleBGColor=#eee|bgColor=#eee}" & txtStackTrace.Text & "\\{panel}")
            Try
                Clipboard.SetText(errReport.ToString)
            Catch ex As Exception
                MessageBox.Show("There was an error copying the data to the clipboard. Please take a screenshot of the error or perform a manual copy of the stack trace.", "Clipboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContinue.Click
            DialogResult = DialogResult.Ignore
        End Sub
    End Class
End NameSpace