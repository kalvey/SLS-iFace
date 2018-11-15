Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmIdCard

    Private Sub Button1_Click(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles Button1.Click

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        xlWorkSheet.Shapes.AddPicture("C:\Users\Ryokm\OneDrive\Desktop\citra.png",
             Microsoft.Office.Core.MsoTriState.msoFalse,
             Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 50, 300, 45)

        xlWorkSheet.SaveAs("D:\vbexcel.xlsx")

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("Excel file created , you can find the file c:\")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class