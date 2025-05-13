Public Class Form1
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim tanggalLahir, tanggalSekarang, bedaBulan, bedaTahun, umurTahun, umurBulan
        tanggalLahir = input_tanggal.Text
        tanggalSekarang = Date.Now()
        bedaBulan = DateDiff(DateInterval.Month, CDate(tanggalLahir), CDate(tanggalSekarang))
        bedaTahun = DateDiff(DateInterval.Year, CDate(tanggalLahir), CDate(tanggalSekarang))
        umurBulan = (bedaBulan - (bedaTahun * 12))
        If umurBulan < 0 Then
            umurTahun = bedaTahun - 1
            umurBulan = umurBulan + 12
        Else
            umurTahun = bedaTahun
        End If
        MsgBox(umurTahun & "tahun" & umurBulan & "bulan")
    End Sub
End Class
